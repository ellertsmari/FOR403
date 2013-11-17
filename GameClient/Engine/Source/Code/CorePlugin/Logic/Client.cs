﻿using Duality;
using Duality.Components;
using Duality.Components.Physics;
using Duality.Components.Renderers;
using Duality.Resources;
using Engine.Components;
using Engine.CustomObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Engine.Logic
{
    //Some code for other Ríkharður : Math.sqrt(Math.pow((float)(Enemy.position.x-Player.position.x), 2) + Math.pow((float)(Enemy.position.y-Player.position.y), 2))

    public class Client
    {
        private static Combat combat;
        private static ContentRef<Scene> previousScene;
        private static ContentRef<Scene> BlankCombatScene = GameRes.Data.Levels.Combat_Scene;
        private static List<GameObject> Team1;
        private static List<GameObject> Team2;

        //Setup Combat
        public static void combatScene(ContentRef<Material> background, List<CreatureContainer> TeamOne, List<CreatureContainer> TeamTwo)
        {
            previousScene = Scene.Current;
            Scene.Current = BlankCombatScene.Res;
            Team1 = new List<GameObject>();
            Team2 = new List<GameObject>();

            foreach (var item in Scene.Current.AllObjects)
            {
                if (item.GetComponent<SpriteRenderer>() != null)
                {
                    item.GetComponent<SpriteRenderer>().SharedMaterial = background;
                    break;
                }
            }

            for (int i = 0; i < TeamOne.Count; i++)
            {
                //Init object and Components
                GameObject Object = new GameObject(TeamOne[i].ToString());
                Object.AddComponent<Transform>();
                Object.AddComponent<AnimSpriteRenderer>();
                Object.AddComponent(new CombatCreatureComponent(TeamOne[i]));

                //Make changes
                Object.Transform.Pos = new OpenTK.Vector3(0, 125 - 40 * TeamOne.Count + 40 * i, -1);
                Object.GetComponent<AnimSpriteRenderer>().SharedMaterial = TeamOne[i].CombatSprite;
                Object.GetComponent<AnimSpriteRenderer>().AnimTime = 0;
                Object.GetComponent<AnimSpriteRenderer>().AnimPaused = false;
                Object.GetComponent<AnimSpriteRenderer>().AnimFirstFrame = Object.GetComponent<CombatCreatureComponent>().IDLEFRAME;
                Object.GetComponent<AnimSpriteRenderer>().AnimDuration = 1f;
                Object.GetComponent<AnimSpriteRenderer>().AnimFrameCount = CreatureContainer.FRAMENUMBER;
                Object.GetComponent<AnimSpriteRenderer>().Rect = TeamOne[i].CombatSpriteRect;
                try
                {
                    Object.AddComponent<ResolutionUpdateComponent>();
                    Object.GetComponent<ResolutionUpdateComponent>().FullWindow = false;
                    Object.GetComponent<ResolutionUpdateComponent>().Scale = 2.0f;
                }
                catch (FORException e)
                {
                    Console.Out.WriteLine(e.Message);
                }

                //Add to list
                Team1.Add(Object);
            }

            for (int i = 0; i < TeamTwo.Count; i++)
            {
                //Init object and Components
                GameObject Object = new GameObject(TeamTwo[i].ToString());
                Object.AddComponent<Transform>();
                Object.AddComponent<AnimSpriteRenderer>();
                Object.AddComponent(new CombatCreatureComponent(TeamTwo[i]));

                //Make changes
                Object.Transform.Pos = new OpenTK.Vector3(300, 125 - (40 * TeamTwo.Count / 2) + 40 * i, -1);
                Object.GetComponent<CombatCreatureComponent>().offsetFrames(48);
                ContentRef<Material> temp = TeamTwo[i].CombatSprite;
                Object.GetComponent<AnimSpriteRenderer>().SharedMaterial = temp;
                Object.GetComponent<AnimSpriteRenderer>().AnimTime = 0;
                Object.GetComponent<AnimSpriteRenderer>().AnimPaused = false;
                Object.GetComponent<AnimSpriteRenderer>().AnimFirstFrame = Object.GetComponent<CombatCreatureComponent>().IDLEFRAME;
                Object.GetComponent<AnimSpriteRenderer>().AnimDuration = 1f;
                Object.GetComponent<AnimSpriteRenderer>().AnimFrameCount = CreatureContainer.FRAMENUMBER;
                Object.GetComponent<AnimSpriteRenderer>().Rect = TeamTwo[i].CombatSpriteRect;

                Object.AddComponent<ResolutionUpdateComponent>();
                Object.GetComponent<ResolutionUpdateComponent>().FullWindow = false;
                Object.GetComponent<ResolutionUpdateComponent>().Scale = 2.0f;

                //Add to list
                Team2.Add(Object);
            }

            //Adding all objects to scene
            Scene.Current.AddObject(Team1);
            Scene.Current.AddObject(Team2);

            combat = new Combat(TeamOne, TeamTwo);

            /*//Run this when the move is selected
            nextRound(TeamOne, TeamTwo);*/
        }

        public static int nextRound(List<CreatureContainer> TeamOne, List<CreatureContainer> TeamTwo)
        {
            int temp = combat.runCombatCycle();
            TeamOne = combat.TeamOne;
            TeamTwo = combat.TeamTwo;
            return temp;
        }

        public static void cleanupScene()
        {
            Scene.Current = BlankCombatScene.Res;
        }

        public static Bitmap flipInternalFunction(Bitmap bitmap)
        {
            bitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);
            return bitmap;
        }
    }

    /*
    public class Test
    {
        public static void test()
        {
            Creature cre1 = new NPC("Peasant", 10, 12, 9, 5);
            Creature cre3 = new NPC("Peasant", 10, 12, 9, 5);
            Creature cre2 = new NPC("Drunkard", 12, 9, 8, 6);
            cre2.setEquipAdmin("Off-Hand", new ItemShield("Off-Hand", 40));
            Combat combat = new Combat(new Creature[] { cre1, cre3 }, new Creature[] { cre2 }, false);
            Console.ReadLine();
        }
    }
    */

    public class FORException : Exception
    {
        public FORException() : base() { }
        public FORException(string message) : base(message) { }
        public FORException(string message, System.Exception inner) : base(message, inner) { }
    }

    public class Message
    {
        public static void sendMessagePlayer(string str)
        {
            Console.Out.WriteLine(str);
        }

        public static void sendMessageDev(string str)
        {
            Console.Out.WriteLine(str);
        }
    }
}
