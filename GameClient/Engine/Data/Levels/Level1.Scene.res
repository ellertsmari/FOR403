<?xml version="1.0" encoding="utf-8"?>
<root>
  <object dataType="Class" type="Duality.Resources.Scene">
    <globalGravity dataType="Struct" type="OpenTK.Vector2">
      <X dataType="Float">0</X>
      <Y dataType="Float">33</Y>
    </globalGravity>
    <serializeObj dataType="Array" type="Duality.GameObject[]" id="292984781" length="3">
      <object dataType="Class" type="Duality.GameObject" id="3301914071">
        <prefabLink dataType="Class" type="Duality.Resources.PrefabLink" id="1220041129">
          <prefab dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Prefab]]">
            <contentPath dataType="String">Data\Player.Prefab.res</contentPath>
          </prefab>
          <obj dataType="ObjectRef">3301914071</obj>
          <changes />
        </prefabLink>
        <identifier dataType="Struct" type="System.Guid" surrogate="true">
          <header>
            <data dataType="Array" type="System.Byte[]" id="1366171274" length="16">dHmKJUUlFkyUy8SboZPLtQ==</data>
          </header>
          <body />
        </identifier>
        <parent />
        <children dataType="Class" type="System.Collections.Generic.List`1[[Duality.GameObject]]" id="3152094606">
          <_items dataType="Array" type="Duality.GameObject[]" id="2760963237" length="4">
            <object dataType="Class" type="Duality.GameObject" id="1351939859">
              <prefabLink />
              <identifier dataType="Struct" type="System.Guid" surrogate="true">
                <header>
                  <data dataType="Array" type="System.Byte[]" id="3072327623" length="16">Vr5lNvFYj0mT2T6UXhF+yg==</data>
                </header>
                <body />
              </identifier>
              <parent dataType="ObjectRef">3301914071</parent>
              <children />
              <compMap dataType="Class" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="1888795005" surrogate="true">
                <header />
                <body>
                  <keys dataType="Array" type="System.Type[]" id="2916064546" length="2">
                    <object dataType="Type" id="4145723348" value="Duality.Components.Transform" />
                    <object dataType="Type" id="2213803032" value="Duality.Components.Camera" />
                  </keys>
                  <values dataType="Array" type="Duality.Component[]" id="2670828892" length="2">
                    <object dataType="Class" type="Duality.Components.Transform" id="3712254791">
                      <pos dataType="Struct" type="OpenTK.Vector3">
                        <X dataType="Float">0.24971962</X>
                        <Y dataType="Float">0.2863617</Y>
                        <Z dataType="Float">-300</Z>
                      </pos>
                      <angle dataType="Float">0.0108782528</angle>
                      <scale dataType="Float">1</scale>
                      <deriveAngle dataType="Bool">true</deriveAngle>
                      <ignoreParent dataType="Bool">false</ignoreParent>
                      <parentTransform dataType="Class" type="Duality.Components.Transform" id="1367261707">
                        <gameobj dataType="ObjectRef">3301914071</gameobj>
                        <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                        <active dataType="Bool">true</active>
                      </parentTransform>
                      <posAbs dataType="Struct" type="OpenTK.Vector3">
                        <X dataType="Float">2.27110863</X>
                        <Y dataType="Float">-16.2305717</Y>
                        <Z dataType="Float">-300</Z>
                      </posAbs>
                      <angleAbs dataType="Float">0.0108782528</angleAbs>
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
                      <gameobj dataType="ObjectRef">1351939859</gameobj>
                      <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                      <active dataType="Bool">true</active>
                    </object>
                    <object dataType="Class" type="Duality.Components.Camera" id="1889215666">
                      <nearZ dataType="Float">0</nearZ>
                      <farZ dataType="Float">10000</farZ>
                      <focusDist dataType="Float">500</focusDist>
                      <perspective dataType="Enum" type="Duality.PerspectiveMode" name="Parallax" value="1" />
                      <visibilityMask dataType="Enum" type="Duality.VisibilityFlag" name="All" value="4294967295" />
                      <passes dataType="Class" type="System.Collections.Generic.List`1[[Duality.Components.Camera+Pass]]" id="1505094188">
                        <_items dataType="Array" type="Duality.Components.Camera+Pass[]" id="1350953416" length="4">
                          <object dataType="Class" type="Duality.Components.Camera+Pass" id="1573503568">
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
                          <object dataType="Class" type="Duality.Components.Camera+Pass" id="3822902880">
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
                      <gameobj dataType="ObjectRef">1351939859</gameobj>
                      <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                      <active dataType="Bool">true</active>
                    </object>
                  </values>
                </body>
              </compMap>
              <compList dataType="Class" type="System.Collections.Generic.List`1[[Duality.Component]]" id="757672854">
                <_items dataType="Array" type="Duality.Component[]" id="617648737" length="4">
                  <object dataType="ObjectRef">3712254791</object>
                  <object dataType="ObjectRef">1889215666</object>
                  <object />
                  <object />
                </_items>
                <_size dataType="Int">2</_size>
                <_version dataType="Int">2</_version>
              </compList>
              <name dataType="String">PlayerCamera</name>
              <active dataType="Bool">true</active>
              <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
              <compTransform dataType="ObjectRef">3712254791</compTransform>
            </object>
            <object />
            <object />
            <object />
          </_items>
          <_size dataType="Int">1</_size>
          <_version dataType="Int">1</_version>
        </children>
        <compMap dataType="Class" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="1649144807" surrogate="true">
          <header />
          <body>
            <keys dataType="Array" type="System.Type[]" id="4060422100" length="4">
              <object dataType="ObjectRef">4145723348</object>
              <object dataType="Type" id="771793352" value="Duality.Components.Renderers.AnimSpriteRenderer" />
              <object dataType="Type" id="83834480" value="Duality.Components.Physics.RigidBody" />
              <object dataType="Type" id="2713856440" value="Engine.PlayerComponent" />
            </keys>
            <values dataType="Array" type="Duality.Component[]" id="54203416" length="4">
              <object dataType="ObjectRef">1367261707</object>
              <object dataType="Class" type="Duality.Components.Renderers.AnimSpriteRenderer" id="3009349452">
                <gameobj dataType="ObjectRef">3301914071</gameobj>
                <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                <active dataType="Bool">true</active>
              </object>
              <object dataType="Class" type="Duality.Components.Physics.RigidBody" id="2069723299">
                <gameobj dataType="ObjectRef">3301914071</gameobj>
                <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                <active dataType="Bool">true</active>
              </object>
              <object dataType="Class" type="Engine.PlayerComponent" id="1019128409">
                <gameobj dataType="ObjectRef">3301914071</gameobj>
                <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                <active dataType="Bool">true</active>
              </object>
            </values>
          </body>
        </compMap>
        <compList dataType="Class" type="System.Collections.Generic.List`1[[Duality.Component]]" id="784242012">
          <_items dataType="Array" type="Duality.Component[]" id="1954391079" length="4">
            <object dataType="ObjectRef">1367261707</object>
            <object dataType="ObjectRef">3009349452</object>
            <object dataType="ObjectRef">2069723299</object>
            <object dataType="ObjectRef">1019128409</object>
          </_items>
          <_size dataType="Int">4</_size>
          <_version dataType="Int">4</_version>
        </compList>
        <name dataType="String">Player</name>
        <active dataType="Bool">true</active>
        <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
        <compTransform dataType="ObjectRef">1367261707</compTransform>
      </object>
      <object dataType="Class" type="Duality.GameObject" id="3491913987">
        <prefabLink />
        <identifier dataType="Struct" type="System.Guid" surrogate="true">
          <header>
            <data dataType="Array" type="System.Byte[]" id="2709675431" length="16">yiRr4UnP1kWE7f4koePkHw==</data>
          </header>
          <body />
        </identifier>
        <parent />
        <children />
        <compMap dataType="Class" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="261296157" surrogate="true">
          <header />
          <body>
            <keys dataType="Array" type="System.Type[]" id="3177856226" length="4">
              <object dataType="ObjectRef">4145723348</object>
              <object dataType="ObjectRef">771793352</object>
              <object dataType="ObjectRef">83834480</object>
              <object dataType="Type" id="864384340" value="Engine.EnemyComponent" />
            </keys>
            <values dataType="Array" type="Duality.Component[]" id="2284345820" length="4">
              <object dataType="Class" type="Duality.Components.Transform" id="1557261623">
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
                <gameobj dataType="ObjectRef">3491913987</gameobj>
                <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                <active dataType="Bool">true</active>
              </object>
              <object dataType="Class" type="Duality.Components.Renderers.AnimSpriteRenderer" id="3199349368">
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
                <gameobj dataType="ObjectRef">3491913987</gameobj>
                <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                <active dataType="Bool">true</active>
              </object>
              <object dataType="Class" type="Duality.Components.Physics.RigidBody" id="2259723215">
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
                <shapes dataType="Class" type="System.Collections.Generic.List`1[[Duality.Components.Physics.ShapeInfo]]" id="3959080281">
                  <_items dataType="Array" type="Duality.Components.Physics.ShapeInfo[]" id="28040522" length="4">
                    <object dataType="Class" type="Duality.Components.Physics.CircleShapeInfo" id="752077860">
                      <radius dataType="Float">128</radius>
                      <position dataType="Struct" type="OpenTK.Vector2">
                        <X dataType="Float">0</X>
                        <Y dataType="Float">0</Y>
                      </position>
                      <parent dataType="ObjectRef">2259723215</parent>
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
                <gameobj dataType="ObjectRef">3491913987</gameobj>
                <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                <active dataType="Bool">true</active>
              </object>
              <object dataType="Class" type="Engine.EnemyComponent" id="1844131042">
                <enemy dataType="Class" type="GameClient.Enemy" id="1344434108">
                  <ai dataType="Class" type="GameClient.defultAI" id="4140751784">
                    <nextAbility />
                    <nextTarget dataType="Int">0</nextTarget>
                  </ai>
                  <name dataType="String">Skeleton</name>
                  <currentTeam dataType="Int">0</currentTeam>
                  <level dataType="Int">1</level>
                  <exp dataType="Int">0</exp>
                  <skillPoints dataType="Int">0</skillPoints>
                  <position />
                  <inventory />
                  <reward />
                  <rewardNum />
                  <primaryAttr dataType="Class" type="System.Collections.Generic.Dictionary`2[[System.String],[System.Int32]]" id="422033456" surrogate="true">
                    <header />
                    <body>
                      <Str dataType="Int">11</Str>
                      <Dex dataType="Int">13</Dex>
                      <Int dataType="Int">3</Int>
                      <Vit dataType="Int">8</Vit>
                    </body>
                  </primaryAttr>
                  <itemAdd dataType="Class" type="System.Collections.Generic.Dictionary`2[[System.String],[System.Int32]]" id="3182209048" surrogate="true">
                    <header />
                    <body>
                      <MaxHP dataType="Int">0</MaxHP>
                      <MaxMP dataType="Int">0</MaxMP>
                      <Str dataType="Int">0</Str>
                      <Dex dataType="Int">0</Dex>
                      <Int dataType="Int">0</Int>
                      <Vit dataType="Int">0</Vit>
                      <DamageReduction dataType="Int">0</DamageReduction>
                    </body>
                  </itemAdd>
                  <secAttr dataType="Class" type="System.Collections.Generic.Dictionary`2[[System.String],[System.Int32]]" id="1234632160" surrogate="true">
                    <header />
                    <body>
                      <MaxHP dataType="Int">32</MaxHP>
                      <HP dataType="Int">32</HP>
                      <MaxMP dataType="Int">12</MaxMP>
                      <MP dataType="Int">12</MP>
                      <Speed dataType="Int">13</Speed>
                      <DamageModMelee dataType="Int">0</DamageModMelee>
                      <DamageModRange dataType="Int">1</DamageModRange>
                      <DamageModMagic dataType="Int">-3</DamageModMagic>
                      <DamageReduction dataType="Int">0</DamageReduction>
                    </body>
                  </secAttr>
                  <itemsEquipped dataType="Class" type="System.Collections.Generic.Dictionary`2[[System.String],[GameClient.Item]]" id="1867473800" surrogate="true">
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
                  <abilities dataType="Class" type="System.Collections.Generic.List`1[[GameClient.Ability]]" id="1463194256">
                    <_items dataType="Array" type="GameClient.Ability[]" id="3410562152" length="0" />
                    <_size dataType="Int">0</_size>
                    <_version dataType="Int">0</_version>
                  </abilities>
                  <resistance dataType="Class" type="System.Collections.Generic.Dictionary`2[[System.String],[System.Int32]]" id="2481332984" surrogate="true">
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
                </enemy>
                <type dataType="Enum" type="Engine.EnemyType" name="Skeleton" value="0" />
                <lvl dataType="Int">0</lvl>
                <s dataType="Int">0</s>
                <d dataType="Int">0</d>
                <v dataType="Int">0</v>
                <i dataType="Int">0</i>
                <abilities dataType="Class" type="System.Collections.Generic.List`1[[Engine.Abilities]]" id="66559672">
                  <_items dataType="Array" type="Engine.Abilities[]" id="2529094732" length="8">
                    <object dataType="Enum" type="Engine.Abilities" name="Punch" value="0" />
                    <object dataType="Enum" type="Engine.Abilities" name="Kick" value="1" />
                    <object dataType="Enum" type="Engine.Abilities" name="Punch" value="0" />
                    <object dataType="Enum" type="Engine.Abilities" name="Punch" value="0" />
                    <object dataType="Enum" type="Engine.Abilities" name="Punch" value="0" />
                    <object dataType="Enum" type="Engine.Abilities" name="Punch" value="0" />
                    <object dataType="Enum" type="Engine.Abilities" name="Punch" value="0" />
                    <object dataType="Enum" type="Engine.Abilities" name="Punch" value="0" />
                  </_items>
                  <_size dataType="Int">2</_size>
                  <_version dataType="Int">16</_version>
                </abilities>
                <gameobj dataType="ObjectRef">3491913987</gameobj>
                <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                <active dataType="Bool">true</active>
              </object>
            </values>
          </body>
        </compMap>
        <compList dataType="Class" type="System.Collections.Generic.List`1[[Duality.Component]]" id="3409372374">
          <_items dataType="Array" type="Duality.Component[]" id="3543795585" length="4">
            <object dataType="ObjectRef">1557261623</object>
            <object dataType="ObjectRef">3199349368</object>
            <object dataType="ObjectRef">2259723215</object>
            <object dataType="ObjectRef">1844131042</object>
          </_items>
          <_size dataType="Int">4</_size>
          <_version dataType="Int">4</_version>
        </compList>
        <name dataType="String">EnemyComponent</name>
        <active dataType="Bool">true</active>
        <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
        <compTransform dataType="ObjectRef">1557261623</compTransform>
      </object>
      <object dataType="ObjectRef">1351939859</object>
    </serializeObj>
    <sourcePath />
  </object>
</root>