<?xml version="1.0" encoding="utf-8"?>
<root>
  <object dataType="Class" type="Duality.Resources.Scene">
    <globalGravity dataType="Struct" type="OpenTK.Vector2">
      <X dataType="Float">0</X>
      <Y dataType="Float">0</Y>
    </globalGravity>
    <serializeObj dataType="Array" type="Duality.GameObject[]" id="292984781" length="4">
      <object dataType="Class" type="Duality.GameObject" id="96510701">
        <prefabLink />
        <identifier dataType="Struct" type="System.Guid" surrogate="true">
          <header>
            <data dataType="Array" type="System.Byte[]" id="3339301641" length="16">POotvu0jf0iiUJif4/+wrg==</data>
          </header>
          <body />
        </identifier>
        <parent />
        <children dataType="Class" type="System.Collections.Generic.List`1[[Duality.GameObject]]" id="216648307">
          <_items dataType="Array" type="Duality.GameObject[]" id="550160162" length="4">
            <object dataType="Class" type="Duality.GameObject" id="4288363316">
              <prefabLink />
              <identifier dataType="Struct" type="System.Guid" surrogate="true">
                <header>
                  <data dataType="Array" type="System.Byte[]" id="2235125880" length="16">x3borXN1h02TQCdLJL22dA==</data>
                </header>
                <body />
              </identifier>
              <parent dataType="ObjectRef">96510701</parent>
              <children />
              <compMap dataType="Class" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="3291715752" surrogate="true">
                <header />
                <body>
                  <keys dataType="Array" type="System.Type[]" id="1604830096" length="2">
                    <object dataType="Type" id="2892522656" value="Duality.Components.Transform" />
                    <object dataType="Type" id="1678900416" value="Duality.Components.Camera" />
                  </keys>
                  <values dataType="Array" type="Duality.Component[]" id="2406444256" length="2">
                    <object dataType="Class" type="Duality.Components.Transform" id="2353710952">
                      <pos dataType="Struct" type="OpenTK.Vector3">
                        <X dataType="Float">0</X>
                        <Y dataType="Float">0</Y>
                        <Z dataType="Float">-250</Z>
                      </pos>
                      <angle dataType="Float">0</angle>
                      <scale dataType="Float">1</scale>
                      <deriveAngle dataType="Bool">true</deriveAngle>
                      <ignoreParent dataType="Bool">false</ignoreParent>
                      <parentTransform dataType="Class" type="Duality.Components.Transform" id="2456825633">
                        <pos dataType="Struct" type="OpenTK.Vector3">
                          <X dataType="Float">0</X>
                          <Y dataType="Float">0</Y>
                          <Z dataType="Float">0</Z>
                        </pos>
                        <angle dataType="Float">0</angle>
                        <scale dataType="Float">1</scale>
                        <deriveAngle dataType="Bool">true</deriveAngle>
                        <ignoreParent dataType="Bool">false</ignoreParent>
                        <parentTransform />
                        <posAbs dataType="Struct" type="OpenTK.Vector3">
                          <X dataType="Float">0</X>
                          <Y dataType="Float">0</Y>
                          <Z dataType="Float">0</Z>
                        </posAbs>
                        <angleAbs dataType="Float">0</angleAbs>
                        <scaleAbs dataType="Float">1</scaleAbs>
                        <vel dataType="Struct" type="OpenTK.Vector3">
                          <X dataType="Float">0</X>
                          <Y dataType="Float">0</Y>
                          <Z dataType="Float">0</Z>
                        </vel>
                        <velAbs dataType="Struct" type="OpenTK.Vector3">
                          <X dataType="Float">0</X>
                          <Y dataType="Float">0</Y>
                          <Z dataType="Float">0</Z>
                        </velAbs>
                        <angleVel dataType="Float">0</angleVel>
                        <angleVelAbs dataType="Float">0</angleVelAbs>
                        <gameobj dataType="ObjectRef">96510701</gameobj>
                        <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                        <active dataType="Bool">true</active>
                      </parentTransform>
                      <posAbs dataType="Struct" type="OpenTK.Vector3">
                        <X dataType="Float">0</X>
                        <Y dataType="Float">0</Y>
                        <Z dataType="Float">-250</Z>
                      </posAbs>
                      <angleAbs dataType="Float">0</angleAbs>
                      <scaleAbs dataType="Float">1</scaleAbs>
                      <vel dataType="Struct" type="OpenTK.Vector3">
                        <X dataType="Float">0</X>
                        <Y dataType="Float">0</Y>
                        <Z dataType="Float">0</Z>
                      </vel>
                      <velAbs dataType="Struct" type="OpenTK.Vector3">
                        <X dataType="Float">0</X>
                        <Y dataType="Float">0</Y>
                        <Z dataType="Float">0</Z>
                      </velAbs>
                      <angleVel dataType="Float">0</angleVel>
                      <angleVelAbs dataType="Float">0</angleVelAbs>
                      <gameobj dataType="ObjectRef">4288363316</gameobj>
                      <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                      <active dataType="Bool">true</active>
                    </object>
                    <object dataType="Class" type="Duality.Components.Camera" id="530671827">
                      <nearZ dataType="Float">0</nearZ>
                      <farZ dataType="Float">10000</farZ>
                      <focusDist dataType="Float">500</focusDist>
                      <perspective dataType="Enum" type="Duality.PerspectiveMode" name="Parallax" value="1" />
                      <visibilityMask dataType="Enum" type="Duality.VisibilityFlag" name="All" value="4294967295" />
                      <passes dataType="Class" type="System.Collections.Generic.List`1[[Duality.Components.Camera+Pass]]" id="3007357915">
                        <_items dataType="Array" type="Duality.Components.Camera+Pass[]" id="3565953298" length="4">
                          <object dataType="Class" type="Duality.Components.Camera+Pass" id="1634301972">
                            <clearColor dataType="Struct" type="Duality.ColorFormat.ColorRgba">
                              <R dataType="Byte">0</R>
                              <G dataType="Byte">0</G>
                              <B dataType="Byte">0</B>
                              <A dataType="Byte">0</A>
                            </clearColor>
                            <clearDepth dataType="Float">1</clearDepth>
                            <clearFlags dataType="Enum" type="Duality.ClearFlag" name="All" value="3" />
                            <matrixMode dataType="Enum" type="Duality.RenderMatrix" name="PerspectiveWorld" value="0" />
                            <visibilityMask dataType="Enum" type="Duality.VisibilityFlag" name="AllGroups" value="2147483647" />
                            <input />
                            <output dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.RenderTarget]]">
                              <contentPath />
                            </output>
                            <CollectDrawcalls />
                          </object>
                          <object dataType="Class" type="Duality.Components.Camera+Pass" id="4111155352">
                            <clearColor dataType="Struct" type="Duality.ColorFormat.ColorRgba">
                              <R dataType="Byte">0</R>
                              <G dataType="Byte">0</G>
                              <B dataType="Byte">0</B>
                              <A dataType="Byte">0</A>
                            </clearColor>
                            <clearDepth dataType="Float">1</clearDepth>
                            <clearFlags dataType="Enum" type="Duality.ClearFlag" name="None" value="0" />
                            <matrixMode dataType="Enum" type="Duality.RenderMatrix" name="OrthoScreen" value="1" />
                            <visibilityMask dataType="Enum" type="Duality.VisibilityFlag" name="All" value="4294967295" />
                            <input />
                            <output dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.RenderTarget]]">
                              <contentPath />
                            </output>
                            <CollectDrawcalls />
                          </object>
                          <object />
                          <object />
                        </_items>
                        <_size dataType="Int">2</_size>
                        <_version dataType="Int">2</_version>
                      </passes>
                      <gameobj dataType="ObjectRef">4288363316</gameobj>
                      <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                      <active dataType="Bool">true</active>
                    </object>
                  </values>
                </body>
              </compMap>
              <compList dataType="Class" type="System.Collections.Generic.List`1[[Duality.Component]]" id="1984276528">
                <_items dataType="Array" type="Duality.Component[]" id="3585979592" length="4">
                  <object dataType="ObjectRef">2353710952</object>
                  <object dataType="ObjectRef">530671827</object>
                  <object />
                  <object />
                </_items>
                <_size dataType="Int">2</_size>
                <_version dataType="Int">2</_version>
              </compList>
              <name dataType="String">PlayerCamera</name>
              <active dataType="Bool">true</active>
              <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
              <compTransform dataType="ObjectRef">2353710952</compTransform>
            </object>
            <object />
            <object />
            <object />
          </_items>
          <_size dataType="Int">1</_size>
          <_version dataType="Int">1</_version>
        </children>
        <compMap dataType="Class" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="442734998" surrogate="true">
          <header />
          <body>
            <keys dataType="Array" type="System.Type[]" id="2334016143" length="4">
              <object dataType="ObjectRef">2892522656</object>
              <object dataType="Type" id="886212778" value="Duality.Components.Physics.RigidBody" />
              <object dataType="Type" id="4106917132" value="Duality.Components.Renderers.AnimSpriteRenderer" />
              <object dataType="Type" id="1600875718" value="Engine.Components.PlayerComponent" />
            </keys>
            <values dataType="Array" type="Duality.Component[]" id="1633543918" length="4">
              <object dataType="ObjectRef">2456825633</object>
              <object dataType="Class" type="Duality.Components.Physics.RigidBody" id="3159287225">
                <bodyType dataType="Enum" type="Duality.Components.Physics.BodyType" name="Dynamic" value="1" />
                <linearDamp dataType="Float">0.3</linearDamp>
                <angularDamp dataType="Float">0.3</angularDamp>
                <fixedAngle dataType="Bool">true</fixedAngle>
                <ignoreGravity dataType="Bool">false</ignoreGravity>
                <continous dataType="Bool">false</continous>
                <linearVel dataType="Struct" type="OpenTK.Vector2">
                  <X dataType="Float">0</X>
                  <Y dataType="Float">0</Y>
                </linearVel>
                <angularVel dataType="Float">0</angularVel>
                <revolutions dataType="Float">0</revolutions>
                <explicitMass dataType="Float">0</explicitMass>
                <colCat dataType="Enum" type="FarseerPhysics.Dynamics.Category" name="Cat1" value="1" />
                <colWith dataType="Enum" type="FarseerPhysics.Dynamics.Category" name="All" value="2147483647" />
                <shapes dataType="Class" type="System.Collections.Generic.List`1[[Duality.Components.Physics.ShapeInfo]]" id="1199732696">
                  <_items dataType="Array" type="Duality.Components.Physics.ShapeInfo[]" id="699334288" length="4">
                    <object dataType="Class" type="Duality.Components.Physics.CircleShapeInfo" id="3018832032">
                      <radius dataType="Float">6.06274128</radius>
                      <position dataType="Struct" type="OpenTK.Vector2">
                        <X dataType="Float">0</X>
                        <Y dataType="Float">9</Y>
                      </position>
                      <parent dataType="ObjectRef">3159287225</parent>
                      <density dataType="Float">1</density>
                      <friction dataType="Float">0.3</friction>
                      <restitution dataType="Float">0.3</restitution>
                      <sensor dataType="Bool">false</sensor>
                    </object>
                    <object />
                    <object />
                    <object />
                  </_items>
                  <_size dataType="Int">1</_size>
                  <_version dataType="Int">1</_version>
                </shapes>
                <joints />
                <gameobj dataType="ObjectRef">96510701</gameobj>
                <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                <active dataType="Bool">true</active>
              </object>
              <object dataType="Class" type="Duality.Components.Renderers.AnimSpriteRenderer" id="4098913378">
                <animFirstFrame dataType="Int">25</animFirstFrame>
                <animFrameCount dataType="Int">8</animFrameCount>
                <animDuration dataType="Float">1</animDuration>
                <animLoopMode dataType="Enum" type="Duality.Components.Renderers.AnimSpriteRenderer+LoopMode" name="Loop" value="1" />
                <animTime dataType="Float">0</animTime>
                <animPaused dataType="Bool">false</animPaused>
                <customFrameSequence />
                <rect dataType="Struct" type="Duality.Rect">
                  <X dataType="Float">-8</X>
                  <Y dataType="Float">-12</Y>
                  <W dataType="Float">16</W>
                  <H dataType="Float">24</H>
                </rect>
                <sharedMat dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Material]]">
                  <contentPath dataType="String">Data\Sprites\HeroSpritesnobgFixed.Material.res</contentPath>
                </sharedMat>
                <customMat />
                <colorTint dataType="Struct" type="Duality.ColorFormat.ColorRgba">
                  <R dataType="Byte">255</R>
                  <G dataType="Byte">255</G>
                  <B dataType="Byte">255</B>
                  <A dataType="Byte">255</A>
                </colorTint>
                <rectMode dataType="Enum" type="Duality.Components.Renderers.SpriteRenderer+UVMode" name="Stretch" value="0" />
                <offset dataType="Int">0</offset>
                <visibilityGroup dataType="Enum" type="Duality.VisibilityFlag" name="Group0" value="1" />
                <gameobj dataType="ObjectRef">96510701</gameobj>
                <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                <active dataType="Bool">true</active>
              </object>
              <object dataType="Class" type="Engine.Components.PlayerComponent" id="4087526585">
                <party dataType="Class" type="System.Collections.Generic.List`1[[Engine.Components.CreatureContainer]]" id="1700081880">
                  <_items dataType="Array" type="Engine.Components.CreatureContainer[]" id="69417104" length="4">
                    <object dataType="Class" type="Engine.Components.CreatureContainer" id="1296670880">
                      <forwardOnSpecial dataType="Bool">false</forwardOnSpecial>
                      <creature dataType="Class" type="Engine.CustomObjects.Player" id="2413099584">
                        <ai dataType="Class" type="Engine.Logic.playerAI" id="1559552640">
                          <setup dataType="Bool">false</setup>
                          <nextAbility />
                          <nextTarget dataType="Int">0</nextTarget>
                        </ai>
                        <creatureID dataType="Int">0</creatureID>
                        <name dataType="String">PlayerOne</name>
                        <currentTeam dataType="Int">0</currentTeam>
                        <inventory dataType="Class" type="Engine.CustomObjects.Inventory" id="3878736640">
                          <gold dataType="Int">0</gold>
                          <inv dataType="Array" type="Engine.CustomObjects.Item[]" id="3321275520" length="16">
                            <object />
                            <object />
                            <object />
                            <object />
                            <object />
                            <object />
                            <object />
                            <object />
                            <object />
                            <object />
                            <object />
                            <object />
                            <object />
                            <object />
                            <object />
                            <object />
                          </inv>
                        </inventory>
                        <stats dataType="Class" type="Engine.CustomObjects.Stats" id="503814528">
                          <_level dataType="Int">1</_level>
                          <_exp dataType="Int">0</_exp>
                          <_skillPoints dataType="Int">0</_skillPoints>
                          <_strength dataType="Int">2</_strength>
                          <_dexterity dataType="Int">2</_dexterity>
                          <_vitality dataType="Int">2</_vitality>
                          <_intelligence dataType="Int">2</_intelligence>
                          <_maxHP dataType="Int">8</_maxHP>
                          <_maxMP dataType="Int">8</_maxMP>
                          <_hp dataType="Int">8</_hp>
                          <_mp dataType="Int">8</_mp>
                          <_damageModMelee dataType="Int">-4</_damageModMelee>
                          <_damageModRange dataType="Int">-4</_damageModRange>
                          <_damageModMagic dataType="Int">-4</_damageModMagic>
                          <_damageReduction dataType="Int">0</_damageReduction>
                          <_speed dataType="Int">2</_speed>
                        </stats>
                        <reward />
                        <rewardNum />
                        <itemsEquipped dataType="Class" type="System.Collections.Generic.Dictionary`2[[System.String],[Engine.CustomObjects.Item]]" id="819777024" surrogate="true">
                          <header />
                          <body>
                            <Head />
                            <Main-Hand />
                            <Off-Hand />
                            <Chest />
                            <RightLeg />
                            <LeftLeg />
                          </body>
                        </itemsEquipped>
                        <abilities dataType="Class" type="System.Collections.Generic.List`1[[Engine.Logic.Ability]]" id="4181647488">
                          <_items dataType="Array" type="Engine.Logic.Ability[]" id="4185324288" length="4">
                            <object dataType="Class" type="Engine.Logic.AttackMeleeBlunt" id="2733625856">
                              <damageMod dataType="Float">1</damageMod>
                              <damageTypes dataType="Class" type="System.Collections.Generic.Dictionary`2[[System.String],[System.Int32]]" id="3799454720" surrogate="true">
                                <header />
                                <body>
                                  <Physical dataType="Int">100</Physical>
                                </body>
                              </damageTypes>
                              <defenderAttr dataType="Int">0</defenderAttr>
                              <resultMessage />
                              <name dataType="String">Punch</name>
                              <MPCost dataType="Int">0</MPCost>
                              <MaxNumTargets dataType="Int">1</MaxNumTargets>
                              <victimType dataType="String">Enemy</victimType>
                              <animType dataType="Enum" type="Engine.Components.Frames" name="MELEEFRAME" value="8" />
                            </object>
                            <object dataType="Class" type="Engine.Logic.AttackMeleeBlunt" id="4016643072">
                              <damageMod dataType="Float">2</damageMod>
                              <damageTypes dataType="Class" type="System.Collections.Generic.Dictionary`2[[System.String],[System.Int32]]" id="1406716416" surrogate="true">
                                <header />
                                <body>
                                  <Physical dataType="Int">100</Physical>
                                </body>
                              </damageTypes>
                              <defenderAttr dataType="Int">0</defenderAttr>
                              <resultMessage />
                              <name dataType="String">Kick</name>
                              <MPCost dataType="Int">0</MPCost>
                              <MaxNumTargets dataType="Int">1</MaxNumTargets>
                              <victimType dataType="String">Enemy</victimType>
                              <animType dataType="Enum" type="Engine.Components.Frames" name="MELEEFRAME" value="8" />
                            </object>
                            <object />
                            <object />
                          </_items>
                          <_size dataType="Int">2</_size>
                          <_version dataType="Int">2</_version>
                        </abilities>
                        <resistance dataType="Class" type="System.Collections.Generic.Dictionary`2[[System.String],[System.Int32]]" id="2578839808" surrogate="true">
                          <header />
                          <body>
                            <Physical dataType="Int">0</Physical>
                            <Fire dataType="Int">0</Fire>
                            <Earth dataType="Int">0</Earth>
                            <Water dataType="Int">0</Water>
                            <Wind dataType="Int">0</Wind>
                            <Dark dataType="Int">0</Dark>
                            <Light dataType="Int">0</Light>
                            <Void dataType="Int">0</Void>
                          </body>
                        </resistance>
                      </creature>
                      <abilities dataType="Class" type="System.Collections.Generic.List`1[[Engine.Constants.NameOfAbility]]" id="3664716672">
                        <_items dataType="Array" type="Engine.Constants.NameOfAbility[]" id="313792832" length="2">
                          <object dataType="Enum" type="Engine.Constants.NameOfAbility" name="Punch" value="0" />
                          <object dataType="Enum" type="Engine.Constants.NameOfAbility" name="Kick" value="1" />
                        </_items>
                        <_size dataType="Int">2</_size>
                        <_version dataType="Int">0</_version>
                      </abilities>
                      <type dataType="Enum" type="Engine.Constants.CreatureType" name="Player" value="0" />
                      <combatSprite dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Material]]">
                        <contentPath dataType="String">Data\Sprites\Wolf.Material.res</contentPath>
                      </combatSprite>
                      <combatRenderBox dataType="Struct" type="Duality.Rect">
                        <X dataType="Float">-37</X>
                        <Y dataType="Float">-22.5</Y>
                        <W dataType="Float">74</W>
                        <H dataType="Float">45</H>
                      </combatRenderBox>
                      <nextTarget dataType="Int">0</nextTarget>
                      <nextAbility />
                    </object>
                    <object />
                    <object />
                    <object />
                  </_items>
                  <_size dataType="Int">1</_size>
                  <_version dataType="Int">1</_version>
                </party>
                <gameobj dataType="ObjectRef">96510701</gameobj>
                <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                <active dataType="Bool">true</active>
              </object>
            </values>
          </body>
        </compMap>
        <compList dataType="Class" type="System.Collections.Generic.List`1[[Duality.Component]]" id="1864648853">
          <_items dataType="Array" type="Duality.Component[]" id="3058076756" length="8">
            <object dataType="ObjectRef">2456825633</object>
            <object dataType="ObjectRef">3159287225</object>
            <object dataType="ObjectRef">4098913378</object>
            <object dataType="ObjectRef">4087526585</object>
            <object />
            <object />
            <object />
            <object />
          </_items>
          <_size dataType="Int">4</_size>
          <_version dataType="Int">6</_version>
        </compList>
        <name dataType="String">Player</name>
        <active dataType="Bool">true</active>
        <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
        <compTransform dataType="ObjectRef">2456825633</compTransform>
      </object>
      <object dataType="Class" type="Duality.GameObject" id="2311454344">
        <prefabLink />
        <identifier dataType="Struct" type="System.Guid" surrogate="true">
          <header>
            <data dataType="Array" type="System.Byte[]" id="3830994122" length="16">xbWEVEF2GkuHe6uvOWd1Vw==</data>
          </header>
          <body />
        </identifier>
        <parent />
        <children />
        <compMap dataType="Class" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="890830414" surrogate="true">
          <header />
          <body>
            <keys dataType="Array" type="System.Type[]" id="499375764" length="4">
              <object dataType="ObjectRef">2892522656</object>
              <object dataType="ObjectRef">886212778</object>
              <object dataType="ObjectRef">4106917132</object>
              <object dataType="Type" id="3386763336" value="Engine.Components.EnemyComponent" />
            </keys>
            <values dataType="Array" type="Duality.Component[]" id="2666447768" length="4">
              <object dataType="Class" type="Duality.Components.Transform" id="376801980">
                <pos dataType="Struct" type="OpenTK.Vector3">
                  <X dataType="Float">180</X>
                  <Y dataType="Float">-166</Y>
                  <Z dataType="Float">0</Z>
                </pos>
                <angle dataType="Float">0</angle>
                <scale dataType="Float">1</scale>
                <deriveAngle dataType="Bool">true</deriveAngle>
                <ignoreParent dataType="Bool">false</ignoreParent>
                <parentTransform />
                <posAbs dataType="Struct" type="OpenTK.Vector3">
                  <X dataType="Float">180</X>
                  <Y dataType="Float">-166</Y>
                  <Z dataType="Float">0</Z>
                </posAbs>
                <angleAbs dataType="Float">0</angleAbs>
                <scaleAbs dataType="Float">1</scaleAbs>
                <vel dataType="Struct" type="OpenTK.Vector3">
                  <X dataType="Float">0</X>
                  <Y dataType="Float">0</Y>
                  <Z dataType="Float">0</Z>
                </vel>
                <velAbs dataType="Struct" type="OpenTK.Vector3">
                  <X dataType="Float">0</X>
                  <Y dataType="Float">0</Y>
                  <Z dataType="Float">0</Z>
                </velAbs>
                <angleVel dataType="Float">0</angleVel>
                <angleVelAbs dataType="Float">0</angleVelAbs>
                <gameobj dataType="ObjectRef">2311454344</gameobj>
                <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                <active dataType="Bool">true</active>
              </object>
              <object dataType="Class" type="Duality.Components.Physics.RigidBody" id="1079263572">
                <bodyType dataType="Enum" type="Duality.Components.Physics.BodyType" name="Dynamic" value="1" />
                <linearDamp dataType="Float">0.3</linearDamp>
                <angularDamp dataType="Float">0.3</angularDamp>
                <fixedAngle dataType="Bool">false</fixedAngle>
                <ignoreGravity dataType="Bool">false</ignoreGravity>
                <continous dataType="Bool">false</continous>
                <linearVel dataType="Struct" type="OpenTK.Vector2">
                  <X dataType="Float">0</X>
                  <Y dataType="Float">0</Y>
                </linearVel>
                <angularVel dataType="Float">0</angularVel>
                <revolutions dataType="Float">0</revolutions>
                <explicitMass dataType="Float">0</explicitMass>
                <colCat dataType="Enum" type="FarseerPhysics.Dynamics.Category" name="Cat1" value="1" />
                <colWith dataType="Enum" type="FarseerPhysics.Dynamics.Category" name="All" value="2147483647" />
                <shapes dataType="Class" type="System.Collections.Generic.List`1[[Duality.Components.Physics.ShapeInfo]]" id="320735448">
                  <_items dataType="Array" type="Duality.Components.Physics.ShapeInfo[]" id="896182416" length="4">
                    <object dataType="Class" type="Duality.Components.Physics.CircleShapeInfo" id="4109451424">
                      <radius dataType="Float">128</radius>
                      <position dataType="Struct" type="OpenTK.Vector2">
                        <X dataType="Float">1</X>
                        <Y dataType="Float">-1</Y>
                      </position>
                      <parent dataType="ObjectRef">1079263572</parent>
                      <density dataType="Float">1</density>
                      <friction dataType="Float">0.3</friction>
                      <restitution dataType="Float">0.3</restitution>
                      <sensor dataType="Bool">false</sensor>
                    </object>
                    <object />
                    <object />
                    <object />
                  </_items>
                  <_size dataType="Int">1</_size>
                  <_version dataType="Int">1</_version>
                </shapes>
                <joints />
                <gameobj dataType="ObjectRef">2311454344</gameobj>
                <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                <active dataType="Bool">true</active>
              </object>
              <object dataType="Class" type="Duality.Components.Renderers.AnimSpriteRenderer" id="2018889725">
                <animFirstFrame dataType="Int">0</animFirstFrame>
                <animFrameCount dataType="Int">0</animFrameCount>
                <animDuration dataType="Float">5</animDuration>
                <animLoopMode dataType="Enum" type="Duality.Components.Renderers.AnimSpriteRenderer+LoopMode" name="Loop" value="1" />
                <animTime dataType="Float">0</animTime>
                <animPaused dataType="Bool">false</animPaused>
                <customFrameSequence />
                <rect dataType="Struct" type="Duality.Rect">
                  <X dataType="Float">-128</X>
                  <Y dataType="Float">-128</Y>
                  <W dataType="Float">256</W>
                  <H dataType="Float">256</H>
                </rect>
                <sharedMat dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Material]]">
                  <contentPath dataType="String">Default:Material:DualityIcon</contentPath>
                </sharedMat>
                <customMat />
                <colorTint dataType="Struct" type="Duality.ColorFormat.ColorRgba">
                  <R dataType="Byte">255</R>
                  <G dataType="Byte">255</G>
                  <B dataType="Byte">255</B>
                  <A dataType="Byte">255</A>
                </colorTint>
                <rectMode dataType="Enum" type="Duality.Components.Renderers.SpriteRenderer+UVMode" name="Stretch" value="0" />
                <offset dataType="Int">0</offset>
                <visibilityGroup dataType="Enum" type="Duality.VisibilityFlag" name="Group0" value="1" />
                <gameobj dataType="ObjectRef">2311454344</gameobj>
                <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                <active dataType="Bool">true</active>
              </object>
              <object dataType="Class" type="Engine.Components.EnemyComponent" id="88778577">
                <groupName dataType="String">Wolf</groupName>
                <creatures dataType="Class" type="System.Collections.Generic.List`1[[Engine.Components.CreatureContainer]]" id="2637141733">
                  <_items dataType="Array" type="Engine.Components.CreatureContainer[]" id="4086408466" length="4">
                    <object dataType="Class" type="Engine.Components.CreatureContainer" id="3000903700">
                      <forwardOnSpecial dataType="Bool">false</forwardOnSpecial>
                      <creature dataType="Class" type="Engine.CustomObjects.Enemy" id="959049544">
                        <__sbo__ai__sbc__k__BackingField dataType="Class" type="Engine.Logic.defultAI" id="3134553168">
                          <nextAbility />
                          <nextTarget dataType="Int">0</nextTarget>
                        </__sbo__ai__sbc__k__BackingField>
                        <creatureID dataType="Int">4</creatureID>
                        <name dataType="String">Wolf</name>
                        <currentTeam dataType="Int">0</currentTeam>
                        <inventory dataType="Class" type="Engine.CustomObjects.Inventory" id="3105659488">
                          <gold dataType="Int">0</gold>
                          <inv dataType="Array" type="Engine.CustomObjects.Item[]" id="2408772752" length="16">
                            <object />
                            <object />
                            <object />
                            <object />
                            <object />
                            <object />
                            <object />
                            <object />
                            <object />
                            <object />
                            <object />
                            <object />
                            <object />
                            <object />
                            <object />
                            <object />
                          </inv>
                        </inventory>
                        <stats dataType="Class" type="Engine.CustomObjects.Stats" id="3467662128">
                          <_level dataType="Int">1</_level>
                          <_exp dataType="Int">0</_exp>
                          <_skillPoints dataType="Int">0</_skillPoints>
                          <_strength dataType="Int">12</_strength>
                          <_dexterity dataType="Int">16</_dexterity>
                          <_vitality dataType="Int">6</_vitality>
                          <_intelligence dataType="Int">5</_intelligence>
                          <_maxHP dataType="Int">24</_maxHP>
                          <_maxMP dataType="Int">20</_maxMP>
                          <_hp dataType="Int">24</_hp>
                          <_mp dataType="Int">20</_mp>
                          <_damageModMelee dataType="Int">1</_damageModMelee>
                          <_damageModRange dataType="Int">3</_damageModRange>
                          <_damageModMagic dataType="Int">-2</_damageModMagic>
                          <_damageReduction dataType="Int">0</_damageReduction>
                          <_speed dataType="Int">16</_speed>
                        </stats>
                        <reward />
                        <rewardNum />
                        <itemsEquipped dataType="Class" type="System.Collections.Generic.Dictionary`2[[System.String],[Engine.CustomObjects.Item]]" id="1382537664" surrogate="true">
                          <header />
                          <body>
                            <Head />
                            <Main-Hand />
                            <Off-Hand />
                            <Chest />
                            <RightLeg />
                            <LeftLeg />
                          </body>
                        </itemsEquipped>
                        <abilities dataType="Class" type="System.Collections.Generic.List`1[[Engine.Logic.Ability]]" id="2629008400">
                          <_items dataType="Array" type="Engine.Logic.Ability[]" id="2589433696" length="4">
                            <object dataType="Class" type="Engine.Logic.AttackMeleeSharp" id="1875049024">
                              <damageMod dataType="Float">1</damageMod>
                              <damageTypes dataType="Class" type="System.Collections.Generic.Dictionary`2[[System.String],[System.Int32]]" id="274784896" surrogate="true">
                                <header />
                                <body>
                                  <Physical dataType="Int">100</Physical>
                                </body>
                              </damageTypes>
                              <defenderAttr dataType="Int">0</defenderAttr>
                              <resultMessage />
                              <name dataType="String">Claw</name>
                              <MPCost dataType="Int">0</MPCost>
                              <MaxNumTargets dataType="Int">1</MaxNumTargets>
                              <victimType dataType="String">Enemy</victimType>
                              <animType dataType="Enum" type="Engine.Components.Frames" name="IDLEFRAME" value="0" />
                            </object>
                            <object />
                            <object />
                            <object />
                          </_items>
                          <_size dataType="Int">1</_size>
                          <_version dataType="Int">1</_version>
                        </abilities>
                        <resistance dataType="Class" type="System.Collections.Generic.Dictionary`2[[System.String],[System.Int32]]" id="3085106976" surrogate="true">
                          <header />
                          <body>
                            <Physical dataType="Int">0</Physical>
                            <Fire dataType="Int">0</Fire>
                            <Earth dataType="Int">0</Earth>
                            <Water dataType="Int">0</Water>
                            <Wind dataType="Int">0</Wind>
                            <Dark dataType="Int">0</Dark>
                            <Light dataType="Int">0</Light>
                            <Void dataType="Int">0</Void>
                          </body>
                        </resistance>
                      </creature>
                      <abilities dataType="Class" type="System.Collections.Generic.List`1[[Engine.Constants.NameOfAbility]]" id="621249648">
                        <_items dataType="Array" type="Engine.Constants.NameOfAbility[]" id="3125875496" length="1">
                          <object dataType="Enum" type="Engine.Constants.NameOfAbility" name="Claw" value="2" />
                        </_items>
                        <_size dataType="Int">1</_size>
                        <_version dataType="Int">0</_version>
                      </abilities>
                      <type dataType="Enum" type="Engine.Constants.CreatureType" name="Wolf" value="4" />
                      <combatSprite dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Material]]">
                        <contentPath dataType="String">Data\Sprites\Wolf.Material.res</contentPath>
                      </combatSprite>
                      <combatRenderBox dataType="Struct" type="Duality.Rect">
                        <X dataType="Float">-37</X>
                        <Y dataType="Float">-22.5</Y>
                        <W dataType="Float">74</W>
                        <H dataType="Float">45</H>
                      </combatRenderBox>
                      <nextTarget dataType="Int">0</nextTarget>
                      <nextAbility />
                    </object>
                    <object />
                    <object />
                    <object />
                  </_items>
                  <_size dataType="Int">1</_size>
                  <_version dataType="Int">2</_version>
                </creatures>
                <gameobj dataType="ObjectRef">2311454344</gameobj>
                <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                <active dataType="Bool">true</active>
              </object>
            </values>
          </body>
        </compMap>
        <compList dataType="Class" type="System.Collections.Generic.List`1[[Duality.Component]]" id="1390875548">
          <_items dataType="Array" type="Duality.Component[]" id="1674236438" length="4">
            <object dataType="ObjectRef">376801980</object>
            <object dataType="ObjectRef">1079263572</object>
            <object dataType="ObjectRef">2018889725</object>
            <object dataType="ObjectRef">88778577</object>
          </_items>
          <_size dataType="Int">4</_size>
          <_version dataType="Int">4</_version>
        </compList>
        <name dataType="String">EnemyComponent</name>
        <active dataType="Bool">true</active>
        <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
        <compTransform dataType="ObjectRef">376801980</compTransform>
      </object>
      <object dataType="Class" type="Duality.GameObject" id="3886175694">
        <prefabLink />
        <identifier dataType="Struct" type="System.Guid" surrogate="true">
          <header>
            <data dataType="Array" type="System.Byte[]" id="480387272" length="16">NxA0HpYtSkWsxNQUtfqNsw==</data>
          </header>
          <body />
        </identifier>
        <parent />
        <children />
        <compMap dataType="Class" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="3367958808" surrogate="true">
          <header />
          <body>
            <keys dataType="Array" type="System.Type[]" id="3932414736" length="2">
              <object dataType="ObjectRef">2892522656</object>
              <object dataType="Type" id="3786146464" value="Engine.CustomRenderers.LayerRenderer" />
            </keys>
            <values dataType="Array" type="Duality.Component[]" id="223876832" length="2">
              <object dataType="Class" type="Duality.Components.Transform" id="1951523330">
                <pos dataType="Struct" type="OpenTK.Vector3">
                  <X dataType="Float">0</X>
                  <Y dataType="Float">0</Y>
                  <Z dataType="Float">0</Z>
                </pos>
                <angle dataType="Float">0</angle>
                <scale dataType="Float">1</scale>
                <deriveAngle dataType="Bool">true</deriveAngle>
                <ignoreParent dataType="Bool">false</ignoreParent>
                <parentTransform />
                <posAbs dataType="Struct" type="OpenTK.Vector3">
                  <X dataType="Float">0</X>
                  <Y dataType="Float">0</Y>
                  <Z dataType="Float">0</Z>
                </posAbs>
                <angleAbs dataType="Float">0</angleAbs>
                <scaleAbs dataType="Float">1</scaleAbs>
                <vel dataType="Struct" type="OpenTK.Vector3">
                  <X dataType="Float">0</X>
                  <Y dataType="Float">0</Y>
                  <Z dataType="Float">0</Z>
                </vel>
                <velAbs dataType="Struct" type="OpenTK.Vector3">
                  <X dataType="Float">0</X>
                  <Y dataType="Float">0</Y>
                  <Z dataType="Float">0</Z>
                </velAbs>
                <angleVel dataType="Float">0</angleVel>
                <angleVelAbs dataType="Float">0</angleVelAbs>
                <gameobj dataType="ObjectRef">3886175694</gameobj>
                <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                <active dataType="Bool">true</active>
              </object>
              <object dataType="Class" type="Engine.CustomRenderers.LayerRenderer" id="2268536341">
                <rect dataType="Struct" type="Duality.Rect">
                  <X dataType="Float">-128</X>
                  <Y dataType="Float">-128</Y>
                  <W dataType="Float">256</W>
                  <H dataType="Float">256</H>
                </rect>
                <sharedMat dataType="Class" type="System.Collections.Generic.List`1[[Duality.ContentRef`1[[Duality.Resources.Material]]]]" id="948336365">
                  <_items dataType="Array" type="Duality.ContentRef`1[[Duality.Resources.Material]][]" id="3892808418" length="4">
                    <object dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Material]]">
                      <contentPath dataType="String">Default:Material:DualityIcon</contentPath>
                    </object>
                    <object dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Material]]">
                      <contentPath />
                    </object>
                    <object dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Material]]">
                      <contentPath />
                    </object>
                    <object dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Material]]">
                      <contentPath />
                    </object>
                  </_items>
                  <_size dataType="Int">1</_size>
                  <_version dataType="Int">7</_version>
                </sharedMat>
                <colorTint dataType="Struct" type="Duality.ColorFormat.ColorRgba">
                  <R dataType="Byte">255</R>
                  <G dataType="Byte">255</G>
                  <B dataType="Byte">255</B>
                  <A dataType="Byte">255</A>
                </colorTint>
                <rectMode dataType="Enum" type="Engine.CustomRenderers.LayerRenderer+UVMode" name="Stretch" value="0" />
                <offset dataType="Int">0</offset>
                <visibilityGroup dataType="Enum" type="Duality.VisibilityFlag" name="Group0" value="1" />
                <gameobj dataType="ObjectRef">3886175694</gameobj>
                <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                <active dataType="Bool">true</active>
              </object>
            </values>
          </body>
        </compMap>
        <compList dataType="Class" type="System.Collections.Generic.List`1[[Duality.Component]]" id="545962672">
          <_items dataType="Array" type="Duality.Component[]" id="2806696440" length="4">
            <object dataType="ObjectRef">1951523330</object>
            <object dataType="ObjectRef">2268536341</object>
            <object />
            <object />
          </_items>
          <_size dataType="Int">2</_size>
          <_version dataType="Int">2</_version>
        </compList>
        <name dataType="String">LayerRenderer</name>
        <active dataType="Bool">true</active>
        <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
        <compTransform dataType="ObjectRef">1951523330</compTransform>
      </object>
      <object dataType="ObjectRef">4288363316</object>
    </serializeObj>
    <sourcePath />
  </object>
</root>