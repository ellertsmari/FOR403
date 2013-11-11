<?xml version="1.0" encoding="utf-8"?>
<root>
  <object dataType="Class" type="Duality.Resources.Scene">
    <globalGravity dataType="Struct" type="OpenTK.Vector2">
      <X dataType="Float">0</X>
      <Y dataType="Float">33</Y>
    </globalGravity>
    <serializeObj dataType="Array" type="Duality.GameObject[]" id="292984781" length="3">
      <object dataType="Class" type="Duality.GameObject" id="1745222944">
        <prefabLink dataType="Class" type="Duality.Resources.PrefabLink" id="1926710182">
          <prefab dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Prefab]]">
            <contentPath dataType="String">Data\Player.Prefab.res</contentPath>
          </prefab>
          <obj dataType="ObjectRef">1745222944</obj>
          <changes />
        </prefabLink>
        <identifier dataType="Struct" type="System.Guid" surrogate="true">
          <header>
            <data dataType="Array" type="System.Byte[]" id="3970839748" length="16">wbuQMJVWk0aOrA7ztpWIcg==</data>
          </header>
          <body />
        </identifier>
        <parent />
        <children dataType="Class" type="System.Collections.Generic.List`1[[Duality.GameObject]]" id="1324221100">
          <_items dataType="Array" type="Duality.GameObject[]" id="3807782366" length="4">
            <object dataType="Class" type="Duality.GameObject" id="1647270055">
              <prefabLink />
              <identifier dataType="Struct" type="System.Guid" surrogate="true">
                <header>
                  <data dataType="Array" type="System.Byte[]" id="141732745" length="16">phGuroGAS0mrw0xtw8ccSg==</data>
                </header>
                <body />
              </identifier>
              <parent dataType="ObjectRef">1745222944</parent>
              <children />
              <compMap dataType="Class" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="2004500467" surrogate="true">
                <header />
                <body>
                  <keys dataType="Array" type="System.Type[]" id="3529497890" length="2">
                    <object dataType="Type" id="3081779156" value="Duality.Components.Transform" />
                    <object dataType="Type" id="431289368" value="Duality.Components.Camera" />
                  </keys>
                  <values dataType="Array" type="Duality.Component[]" id="4021689692" length="2">
                    <object dataType="Class" type="Duality.Components.Transform" id="4007584987">
                      <pos dataType="Struct" type="OpenTK.Vector3">
                        <X dataType="Float">0.24971962</X>
                        <Y dataType="Float">0.2863617</Y>
                        <Z dataType="Float">-300</Z>
                      </pos>
                      <angle dataType="Float">0.0108782528</angle>
                      <scale dataType="Float">1</scale>
                      <deriveAngle dataType="Bool">true</deriveAngle>
                      <ignoreParent dataType="Bool">false</ignoreParent>
                      <parentTransform dataType="Class" type="Duality.Components.Transform" id="4105537876">
                        <gameobj dataType="ObjectRef">1745222944</gameobj>
                        <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                        <active dataType="Bool">true</active>
                      </parentTransform>
                      <posAbs dataType="Struct" type="OpenTK.Vector3">
                        <X dataType="Float">0.24971962</X>
                        <Y dataType="Float">0.2863617</Y>
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
                      <gameobj dataType="ObjectRef">1647270055</gameobj>
                      <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                      <active dataType="Bool">true</active>
                    </object>
                    <object dataType="Class" type="Duality.Components.Camera" id="2184545862">
                      <nearZ dataType="Float">0</nearZ>
                      <farZ dataType="Float">10000</farZ>
                      <focusDist dataType="Float">500</focusDist>
                      <perspective dataType="Enum" type="Duality.PerspectiveMode" name="Parallax" value="1" />
                      <visibilityMask dataType="Enum" type="Duality.VisibilityFlag" name="All" value="4294967295" />
                      <passes dataType="Class" type="System.Collections.Generic.List`1[[Duality.Components.Camera+Pass]]" id="54664312">
                        <_items dataType="Array" type="Duality.Components.Camera+Pass[]" id="1384150352" length="4">
                          <object dataType="Class" type="Duality.Components.Camera+Pass" id="3303526176">
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
                          <object dataType="Class" type="Duality.Components.Camera+Pass" id="737724864">
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
                      <gameobj dataType="ObjectRef">1647270055</gameobj>
                      <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                      <active dataType="Bool">true</active>
                    </object>
                  </values>
                </body>
              </compMap>
              <compList dataType="Class" type="System.Collections.Generic.List`1[[Duality.Component]]" id="2709515158">
                <_items dataType="Array" type="Duality.Component[]" id="854411279" length="4">
                  <object dataType="ObjectRef">4007584987</object>
                  <object dataType="ObjectRef">2184545862</object>
                  <object />
                  <object />
                </_items>
                <_size dataType="Int">2</_size>
                <_version dataType="Int">2</_version>
              </compList>
              <name dataType="String">PlayerCamera</name>
              <active dataType="Bool">true</active>
              <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
              <compTransform dataType="ObjectRef">4007584987</compTransform>
            </object>
            <object />
            <object />
            <object />
          </_items>
          <_size dataType="Int">1</_size>
          <_version dataType="Int">1</_version>
        </children>
        <compMap dataType="Class" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="3596608874" surrogate="true">
          <header />
          <body>
            <keys dataType="Array" type="System.Type[]" id="3741259560" length="4">
              <object dataType="ObjectRef">3081779156</object>
              <object dataType="Type" id="196782224" value="Duality.Components.Renderers.AnimSpriteRenderer" />
              <object dataType="Type" id="4093419744" value="Duality.Components.Physics.RigidBody" />
              <object dataType="Type" id="2856027248" value="Engine.PlayerComponent" />
            </keys>
            <values dataType="Array" type="Duality.Component[]" id="915033904" length="4">
              <object dataType="ObjectRef">4105537876</object>
              <object dataType="Class" type="Duality.Components.Renderers.AnimSpriteRenderer" id="1452658325">
                <gameobj dataType="ObjectRef">1745222944</gameobj>
                <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                <active dataType="Bool">true</active>
              </object>
              <object dataType="Class" type="Duality.Components.Physics.RigidBody" id="513032172">
                <gameobj dataType="ObjectRef">1745222944</gameobj>
                <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                <active dataType="Bool">true</active>
              </object>
              <object dataType="Class" type="Engine.PlayerComponent" id="3757404578">
                <gameobj dataType="ObjectRef">1745222944</gameobj>
                <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                <active dataType="Bool">true</active>
              </object>
            </values>
          </body>
        </compMap>
        <compList dataType="Class" type="System.Collections.Generic.List`1[[Duality.Component]]" id="721003832">
          <_items dataType="Array" type="Duality.Component[]" id="3720927306" length="4">
            <object dataType="ObjectRef">4105537876</object>
            <object dataType="ObjectRef">1452658325</object>
            <object dataType="ObjectRef">513032172</object>
            <object dataType="ObjectRef">3757404578</object>
          </_items>
          <_size dataType="Int">4</_size>
          <_version dataType="Int">4</_version>
        </compList>
        <name dataType="String">Player</name>
        <active dataType="Bool">true</active>
        <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
        <compTransform dataType="ObjectRef">4105537876</compTransform>
      </object>
      <object dataType="Class" type="Duality.GameObject" id="274591137">
        <prefabLink />
        <identifier dataType="Struct" type="System.Guid" surrogate="true">
          <header>
            <data dataType="Array" type="System.Byte[]" id="2127551517" length="16">WKB1nyib/02coRTnli5IBg==</data>
          </header>
          <body />
        </identifier>
        <parent />
        <children />
        <compMap dataType="Class" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="553515407" surrogate="true">
          <header />
          <body>
            <keys dataType="Array" type="System.Type[]" id="2945071786" length="4">
              <object dataType="ObjectRef">3081779156</object>
              <object dataType="ObjectRef">196782224</object>
              <object dataType="ObjectRef">4093419744</object>
              <object dataType="Type" id="1154877924" value="Engine.EnemyComponent" />
            </keys>
            <values dataType="Array" type="Duality.Component[]" id="3274214668" length="4">
              <object dataType="Class" type="Duality.Components.Transform" id="2634906069">
                <pos dataType="Struct" type="OpenTK.Vector3">
                  <X dataType="Float">153</X>
                  <Y dataType="Float">-147</Y>
                  <Z dataType="Float">0</Z>
                </pos>
                <angle dataType="Float">0</angle>
                <scale dataType="Float">1</scale>
                <deriveAngle dataType="Bool">true</deriveAngle>
                <ignoreParent dataType="Bool">false</ignoreParent>
                <parentTransform />
                <posAbs dataType="Struct" type="OpenTK.Vector3">
                  <X dataType="Float">153</X>
                  <Y dataType="Float">-147</Y>
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
                <gameobj dataType="ObjectRef">274591137</gameobj>
                <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                <active dataType="Bool">true</active>
              </object>
              <object dataType="Class" type="Duality.Components.Renderers.AnimSpriteRenderer" id="4276993814">
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
                <gameobj dataType="ObjectRef">274591137</gameobj>
                <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                <active dataType="Bool">true</active>
              </object>
              <object dataType="Class" type="Duality.Components.Physics.RigidBody" id="3337367661">
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
                <shapes dataType="Class" type="System.Collections.Generic.List`1[[Duality.Components.Physics.ShapeInfo]]" id="587242019">
                  <_items dataType="Array" type="Duality.Components.Physics.ShapeInfo[]" id="3691161698" length="4">
                    <object dataType="Class" type="Duality.Components.Physics.CircleShapeInfo" id="2656561236">
                      <radius dataType="Float">128</radius>
                      <position dataType="Struct" type="OpenTK.Vector2">
                        <X dataType="Float">0</X>
                        <Y dataType="Float">0</Y>
                      </position>
                      <parent dataType="ObjectRef">3337367661</parent>
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
                <gameobj dataType="ObjectRef">274591137</gameobj>
                <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                <active dataType="Bool">true</active>
              </object>
              <object dataType="Class" type="Engine.EnemyComponent" id="2921775488">
                <enemy dataType="Class" type="Engine.Enemy" id="3541723062">
                  <__sbo__ai__sbc__k__BackingField dataType="Class" type="Engine.defultAI" id="1101922852">
                    <nextAbility />
                    <nextTarget dataType="Int">0</nextTarget>
                  </__sbo__ai__sbc__k__BackingField>
                  <name dataType="String">Wolf</name>
                  <currentTeam dataType="Int">0</currentTeam>
                  <position />
                  <inventory />
                  <stats dataType="Class" type="Engine.Stats" id="164431928">
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
                  <itemsEquipped dataType="Class" type="System.Collections.Generic.Dictionary`2[[System.String],[Engine.Item]]" id="621848860" surrogate="true">
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
                  <abilities dataType="Class" type="System.Collections.Generic.List`1[[Engine.Ability]]" id="316194160">
                    <_items dataType="Array" type="Engine.Ability[]" id="1547418396" length="0" />
                    <_size dataType="Int">0</_size>
                    <_version dataType="Int">0</_version>
                  </abilities>
                  <resistance dataType="Class" type="System.Collections.Generic.Dictionary`2[[System.String],[System.Int32]]" id="2263726580" surrogate="true">
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
                <type dataType="Enum" type="Engine.Constants.EnemyType" name="Wolf" value="3" />
                <abilities dataType="Class" type="System.Collections.Generic.List`1[[Engine.Constants.NameOfAbility]]" id="3202145228">
                  <_items dataType="Array" type="Engine.Constants.NameOfAbility[]" id="1493183534" length="4">
                    <object dataType="Enum" type="Engine.Constants.NameOfAbility" name="Claw" value="2" />
                    <object dataType="Enum" type="Engine.Constants.NameOfAbility" name="Punch" value="0" />
                    <object dataType="Enum" type="Engine.Constants.NameOfAbility" name="Punch" value="0" />
                    <object dataType="Enum" type="Engine.Constants.NameOfAbility" name="Punch" value="0" />
                  </_items>
                  <_size dataType="Int">1</_size>
                  <_version dataType="Int">5</_version>
                </abilities>
                <realAbilities dataType="Class" type="System.Collections.Generic.List`1[[Engine.Ability]]" id="1625225178">
                  <_items dataType="Array" type="Engine.Ability[]" id="2321867560" length="4">
                    <object dataType="Class" type="Engine.AttackMeleeSharp" id="3534127248">
                      <damageMod dataType="Float">1</damageMod>
                      <damageTypes dataType="Class" type="System.Collections.Generic.Dictionary`2[[System.String],[System.Int32]]" id="1280340128" surrogate="true">
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
                    </object>
                    <object />
                    <object />
                    <object />
                  </_items>
                  <_size dataType="Int">1</_size>
                  <_version dataType="Int">1</_version>
                </realAbilities>
                <gameobj dataType="ObjectRef">274591137</gameobj>
                <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                <active dataType="Bool">true</active>
              </object>
            </values>
          </body>
        </compMap>
        <compList dataType="Class" type="System.Collections.Generic.List`1[[Duality.Component]]" id="4057902318">
          <_items dataType="Array" type="Duality.Component[]" id="4171280755" length="4">
            <object dataType="ObjectRef">2634906069</object>
            <object dataType="ObjectRef">4276993814</object>
            <object dataType="ObjectRef">3337367661</object>
            <object dataType="ObjectRef">2921775488</object>
          </_items>
          <_size dataType="Int">4</_size>
          <_version dataType="Int">4</_version>
        </compList>
        <name dataType="String">EnemyComponent</name>
        <active dataType="Bool">true</active>
        <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
        <compTransform dataType="ObjectRef">2634906069</compTransform>
      </object>
      <object dataType="ObjectRef">1647270055</object>
    </serializeObj>
    <sourcePath />
  </object>
</root>