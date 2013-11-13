<?xml version="1.0" encoding="utf-8"?>
<root>
  <object dataType="Class" type="Duality.Resources.Prefab">
    <objTree dataType="Class" type="Duality.GameObject" id="1472296175">
      <prefabLink />
      <identifier dataType="Struct" type="System.Guid" surrogate="true">
        <header>
          <data dataType="Array" type="System.Byte[]" id="2215516496" length="16">hTkTn9K3vk2e/H9NJ78s1A==</data>
        </header>
        <body />
      </identifier>
      <parent />
      <children dataType="Class" type="System.Collections.Generic.List`1[[Duality.GameObject]]" id="2952958832">
        <_items dataType="Array" type="Duality.GameObject[]" id="4105400480" length="4">
          <object dataType="Class" type="Duality.GameObject" id="2534581906">
            <prefabLink />
            <identifier dataType="Struct" type="System.Guid" surrogate="true">
              <header>
                <data dataType="Array" type="System.Byte[]" id="1532756998" length="16">s+ipWLtYnU6/v5c3mv1VvA==</data>
              </header>
              <body />
            </identifier>
            <parent dataType="ObjectRef">1472296175</parent>
            <children />
            <compMap dataType="Class" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="1936721826" surrogate="true">
              <header />
              <body>
                <keys dataType="Array" type="System.Type[]" id="358265300" length="2">
                  <object dataType="Type" id="534405576" value="Duality.Components.Transform" />
                  <object dataType="Type" id="1831646832" value="Duality.Components.Camera" />
                </keys>
                <values dataType="Array" type="Duality.Component[]" id="1225937944" length="2">
                  <object dataType="Class" type="Duality.Components.Transform" id="599929542">
                    <pos dataType="Struct" type="OpenTK.Vector3">
                      <X dataType="Float">0.24971962</X>
                      <Y dataType="Float">0.2863617</Y>
                      <Z dataType="Float">-300</Z>
                    </pos>
                    <angle dataType="Float">0.0108782528</angle>
                    <scale dataType="Float">1</scale>
                    <deriveAngle dataType="Bool">true</deriveAngle>
                    <ignoreParent dataType="Bool">false</ignoreParent>
                    <parentTransform dataType="Class" type="Duality.Components.Transform" id="3832611107">
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
                      <gameobj dataType="ObjectRef">1472296175</gameobj>
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
                    <gameobj dataType="ObjectRef">2534581906</gameobj>
                    <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                    <active dataType="Bool">true</active>
                  </object>
                  <object dataType="Class" type="Duality.Components.Camera" id="3071857713">
                    <nearZ dataType="Float">0</nearZ>
                    <farZ dataType="Float">10000</farZ>
                    <focusDist dataType="Float">500</focusDist>
                    <perspective dataType="Enum" type="Duality.PerspectiveMode" name="Parallax" value="1" />
                    <visibilityMask dataType="Enum" type="Duality.VisibilityFlag" name="All" value="4294967295" />
                    <passes dataType="Class" type="System.Collections.Generic.List`1[[Duality.Components.Camera+Pass]]" id="3355952901">
                      <_items dataType="Array" type="Duality.Components.Camera+Pass[]" id="3772497874" length="4">
                        <object dataType="Class" type="Duality.Components.Camera+Pass" id="761771796">
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
                        <object dataType="Class" type="Duality.Components.Camera+Pass" id="4219913880">
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
                    <gameobj dataType="ObjectRef">2534581906</gameobj>
                    <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                    <active dataType="Bool">true</active>
                  </object>
                </values>
              </body>
            </compMap>
            <compList dataType="Class" type="System.Collections.Generic.List`1[[Duality.Component]]" id="1180040028">
              <_items dataType="Array" type="Duality.Component[]" id="116072026" length="4">
                <object dataType="ObjectRef">599929542</object>
                <object dataType="ObjectRef">3071857713</object>
                <object />
                <object />
              </_items>
              <_size dataType="Int">2</_size>
              <_version dataType="Int">2</_version>
            </compList>
            <name dataType="String">PlayerCamera</name>
            <active dataType="Bool">true</active>
            <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
            <compTransform dataType="ObjectRef">599929542</compTransform>
          </object>
          <object />
          <object />
          <object />
        </_items>
        <_size dataType="Int">1</_size>
        <_version dataType="Int">1</_version>
      </children>
      <compMap dataType="Class" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="2484056288" surrogate="true">
        <header />
        <body>
          <keys dataType="Array" type="System.Type[]" id="3144599472" length="4">
            <object dataType="ObjectRef">534405576</object>
            <object dataType="Type" id="2082581792" value="Duality.Components.Renderers.AnimSpriteRenderer" />
            <object dataType="Type" id="275042752" value="Duality.Components.Physics.RigidBody" />
            <object dataType="Type" id="4221252832" value="Engine.PlayerComponent" />
          </keys>
          <values dataType="Array" type="Duality.Component[]" id="971002464" length="4">
            <object dataType="ObjectRef">3832611107</object>
            <object dataType="Class" type="Duality.Components.Renderers.AnimSpriteRenderer" id="1179731556">
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
              <gameobj dataType="ObjectRef">1472296175</gameobj>
              <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
              <active dataType="Bool">true</active>
            </object>
            <object dataType="Class" type="Duality.Components.Physics.RigidBody" id="240105403">
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
              <shapes dataType="Class" type="System.Collections.Generic.List`1[[Duality.Components.Physics.ShapeInfo]]" id="459104483">
                <_items dataType="Array" type="Duality.Components.Physics.ShapeInfo[]" id="34401506" length="4">
                  <object dataType="Class" type="Duality.Components.Physics.CircleShapeInfo" id="597833044">
                    <radius dataType="Float">5.76394749</radius>
                    <position dataType="Struct" type="OpenTK.Vector2">
                      <X dataType="Float">0</X>
                      <Y dataType="Float">7.90286255</Y>
                    </position>
                    <parent dataType="ObjectRef">240105403</parent>
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
              <gameobj dataType="ObjectRef">1472296175</gameobj>
              <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
              <active dataType="Bool">true</active>
            </object>
            <object dataType="Class" type="Engine.PlayerComponent" id="3484477809">
              <player dataType="Class" type="Engine.Player" id="2401379593">
                <name dataType="String">Player One</name>
                <currentTeam dataType="Int">0</currentTeam>
                <position />
                <inventory />
                <stats dataType="Class" type="Engine.Stats" id="3297825546">
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
                <itemsEquipped dataType="Class" type="System.Collections.Generic.Dictionary`2[[System.String],[Engine.Item]]" id="3428448844" surrogate="true">
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
                <abilities dataType="Class" type="System.Collections.Generic.List`1[[Engine.Ability]]" id="352843494">
                  <_items dataType="Array" type="Engine.Ability[]" id="1595977768" length="0" />
                  <_size dataType="Int">0</_size>
                  <_version dataType="Int">0</_version>
                </abilities>
                <resistance dataType="Class" type="System.Collections.Generic.Dictionary`2[[System.String],[System.Int32]]" id="3891611704" surrogate="true">
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
              </player>
              <gameobj dataType="ObjectRef">1472296175</gameobj>
              <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
              <active dataType="Bool">true</active>
            </object>
          </values>
        </body>
      </compMap>
      <compList dataType="Class" type="System.Collections.Generic.List`1[[Duality.Component]]" id="140355472">
        <_items dataType="Array" type="Duality.Component[]" id="3218306368" length="4">
          <object dataType="ObjectRef">3832611107</object>
          <object dataType="ObjectRef">1179731556</object>
          <object dataType="ObjectRef">240105403</object>
          <object dataType="ObjectRef">3484477809</object>
        </_items>
        <_size dataType="Int">4</_size>
        <_version dataType="Int">4</_version>
      </compList>
      <name dataType="String">Player</name>
      <active dataType="Bool">true</active>
      <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
      <compTransform dataType="ObjectRef">3832611107</compTransform>
    </objTree>
    <sourcePath />
  </object>
</root>