﻿<?xml version="1.0" encoding="utf-8"?>
<root>
  <object dataType="Class" type="Duality.Resources.Scene">
    <globalGravity dataType="Struct" type="OpenTK.Vector2">
      <X dataType="Float">0</X>
      <Y dataType="Float">0</Y>
    </globalGravity>
    <serializeObj dataType="Array" type="Duality.GameObject[]" id="292984781" length="2">
      <object dataType="Class" type="Duality.GameObject" id="3124348815">
        <name dataType="String">Player</name>
        <prefabLink dataType="Class" type="Duality.Resources.PrefabLink" id="3442645825">
          <prefab dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Prefab]]">
            <contentPath dataType="String">Data\Player.Prefab.res</contentPath>
          </prefab>
          <obj dataType="ObjectRef">3124348815</obj>
          <changes dataType="Class" type="System.Collections.Generic.List`1[[Duality.Resources.PrefabLink+VarMod]]" id="2370364842">
            <_items dataType="Array" type="Duality.Resources.PrefabLink+VarMod[]" id="1211225060" length="4">
              <object dataType="Struct" type="Duality.Resources.PrefabLink+VarMod">
                <prop dataType="PropertyInfo" id="1941099512" value="P:Duality.Components.Renderers.AnimSpriteRenderer:AnimPaused" />
                <componentType dataType="Type" id="3017421680" value="Duality.Components.Renderers.AnimSpriteRenderer" />
                <childIndex dataType="Class" type="System.Collections.Generic.List`1[[System.Int32]]" id="2654000776">
                  <_items dataType="Array" type="System.Int32[]" id="1262930592" length="0" />
                  <_size dataType="Int">0</_size>
                  <_version dataType="Int">1</_version>
                </childIndex>
                <val dataType="Bool">true</val>
              </object>
              <object dataType="Struct" type="Duality.Resources.PrefabLink+VarMod">
                <prop dataType="PropertyInfo" id="4214173408" value="P:Duality.Components.Renderers.AnimSpriteRenderer:AnimFrameCount" />
                <componentType dataType="ObjectRef">3017421680</componentType>
                <childIndex dataType="Class" type="System.Collections.Generic.List`1[[System.Int32]]" id="2905183704">
                  <_items dataType="ObjectRef">1262930592</_items>
                  <_size dataType="Int">0</_size>
                  <_version dataType="Int">1</_version>
                </childIndex>
                <val dataType="Int">8</val>
              </object>
              <object dataType="Struct" type="Duality.Resources.PrefabLink+VarMod">
                <prop dataType="PropertyInfo" id="1864859600" value="P:Duality.Components.Transform:RelativePos" />
                <componentType dataType="Type" id="3436961384" value="Duality.Components.Transform" />
                <childIndex dataType="Class" type="System.Collections.Generic.List`1[[System.Int32]]" id="1143746496">
                  <_items dataType="Array" type="System.Int32[]" id="3490760488" length="0" />
                  <_size dataType="Int">0</_size>
                  <_version dataType="Int">1</_version>
                </childIndex>
                <val dataType="Struct" type="OpenTK.Vector3">
                  <X dataType="Float">1772.5</X>
                  <Y dataType="Float">435.833344</Y>
                  <Z dataType="Float">0</Z>
                </val>
              </object>
              <object dataType="Struct" type="Duality.Resources.PrefabLink+VarMod">
                <prop />
                <componentType />
                <childIndex />
                <val />
              </object>
            </_items>
            <_size dataType="Int">3</_size>
            <_version dataType="Int">241</_version>
          </changes>
        </prefabLink>
        <identifier dataType="Struct" type="System.Guid" surrogate="true">
          <header>
            <data dataType="Array" type="System.Byte[]" id="1164172044" length="16">tIt3nU4HyEymDCBLmFoE8w==</data>
          </header>
          <body />
        </identifier>
        <parent />
        <children dataType="Class" type="System.Collections.Generic.List`1[[Duality.GameObject]]" id="230438382">
          <_items dataType="Array" type="Duality.GameObject[]" id="1123149117" length="4">
            <object dataType="Class" type="Duality.GameObject" id="1568033940">
              <name dataType="String">PlayerCamera</name>
              <prefabLink />
              <identifier dataType="Struct" type="System.Guid" surrogate="true">
                <header>
                  <data dataType="Array" type="System.Byte[]" id="3030082198" length="16">nwmGBvDM60WyE5egwmMO4A==</data>
                </header>
                <body />
              </identifier>
              <parent dataType="ObjectRef">3124348815</parent>
              <children />
              <compMap dataType="Class" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="3249309906" surrogate="true">
                <header />
                <body>
                  <keys dataType="Array" type="System.Type[]" id="3537246996" length="2">
                    <object dataType="ObjectRef">3436961384</object>
                    <object dataType="Type" id="3651416392" value="Duality.Components.Camera" />
                  </keys>
                  <values dataType="Array" type="Duality.Component[]" id="1398863512" length="2">
                    <object dataType="Class" type="Duality.Components.Transform" id="3928348872">
                      <pos dataType="Struct" type="OpenTK.Vector3">
                        <X dataType="Float">0.24971962</X>
                        <Y dataType="Float">0.2863617</Y>
                        <Z dataType="Float">-300</Z>
                      </pos>
                      <angle dataType="Float">0.0108782528</angle>
                      <scale dataType="Float">1</scale>
                      <deriveAngle dataType="Bool">true</deriveAngle>
                      <ignoreParent dataType="Bool">false</ignoreParent>
                      <parentTransform dataType="Class" type="Duality.Components.Transform" id="1189696451">
                        <gameobj dataType="ObjectRef">3124348815</gameobj>
                        <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                        <active dataType="Bool">true</active>
                      </parentTransform>
                      <posAbs dataType="Struct" type="OpenTK.Vector3">
                        <X dataType="Float">1772.74976</X>
                        <Y dataType="Float">436.1197</Y>
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
                      <gameobj dataType="ObjectRef">1568033940</gameobj>
                      <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                      <active dataType="Bool">true</active>
                    </object>
                    <object dataType="Class" type="Duality.Components.Camera" id="2105309747">
                      <nearZ dataType="Float">0</nearZ>
                      <farZ dataType="Float">10000</farZ>
                      <focusDist dataType="Float">500</focusDist>
                      <perspective dataType="Enum" type="Duality.PerspectiveMode" name="Parallax" value="1" />
                      <visibilityMask dataType="Enum" type="Duality.VisibilityFlag" name="All" value="4294967295" />
                      <passes dataType="Class" type="System.Collections.Generic.List`1[[Duality.Components.Camera+Pass]]" id="1966567575">
                        <_items dataType="Array" type="Duality.Components.Camera+Pass[]" id="2366773642" length="4">
                          <object dataType="Class" type="Duality.Components.Camera+Pass" id="2428946596">
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
                          <object dataType="Class" type="Duality.Components.Camera+Pass" id="1874290232">
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
                      <gameobj dataType="ObjectRef">1568033940</gameobj>
                      <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                      <active dataType="Bool">true</active>
                    </object>
                  </values>
                </body>
              </compMap>
              <compList dataType="Class" type="System.Collections.Generic.List`1[[Duality.Component]]" id="721663260">
                <_items dataType="Array" type="Duality.Component[]" id="2708600266" length="4">
                  <object dataType="ObjectRef">3928348872</object>
                  <object dataType="ObjectRef">2105309747</object>
                  <object />
                  <object />
                </_items>
                <_size dataType="Int">2</_size>
                <_version dataType="Int">6</_version>
              </compList>
              <active dataType="Bool">true</active>
              <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
              <compTransform dataType="ObjectRef">3928348872</compTransform>
            </object>
            <object />
            <object />
            <object />
          </_items>
          <_size dataType="Int">1</_size>
          <_version dataType="Int">1</_version>
        </children>
        <compMap dataType="Class" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="461766639" surrogate="true">
          <header />
          <body>
            <keys dataType="Array" type="System.Type[]" id="1658897620" length="4">
              <object dataType="ObjectRef">3436961384</object>
              <object dataType="ObjectRef">3017421680</object>
              <object dataType="Type" id="433291208" value="Duality.Components.Physics.RigidBody" />
              <object dataType="Type" id="2145835632" value="Engine.PlayerComponent" />
            </keys>
            <values dataType="Array" type="Duality.Component[]" id="383745560" length="4">
              <object dataType="ObjectRef">1189696451</object>
              <object dataType="Class" type="Duality.Components.Renderers.AnimSpriteRenderer" id="2831784196">
                <gameobj dataType="ObjectRef">3124348815</gameobj>
                <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                <active dataType="Bool">true</active>
              </object>
              <object dataType="Class" type="Duality.Components.Physics.RigidBody" id="1892158043">
                <gameobj dataType="ObjectRef">3124348815</gameobj>
                <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                <active dataType="Bool">true</active>
              </object>
              <object dataType="Class" type="Engine.PlayerComponent" id="841563153">
                <gameobj dataType="ObjectRef">3124348815</gameobj>
                <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                <active dataType="Bool">true</active>
              </object>
            </values>
          </body>
        </compMap>
        <compList dataType="Class" type="System.Collections.Generic.List`1[[Duality.Component]]" id="1737456732">
          <_items dataType="Array" type="Duality.Component[]" id="3826929887" length="8">
            <object dataType="ObjectRef">1189696451</object>
            <object dataType="ObjectRef">2831784196</object>
            <object dataType="ObjectRef">1892158043</object>
            <object dataType="ObjectRef">841563153</object>
            <object />
            <object />
            <object />
            <object />
          </_items>
          <_size dataType="Int">4</_size>
          <_version dataType="Int">6</_version>
        </compList>
        <active dataType="Bool">true</active>
        <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
        <compTransform dataType="ObjectRef">1189696451</compTransform>
      </object>
      <object dataType="ObjectRef">1568033940</object>
    </serializeObj>
    <sourcePath />
  </object>
</root>