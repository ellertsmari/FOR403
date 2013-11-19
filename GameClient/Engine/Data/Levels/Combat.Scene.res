<?xml version="1.0" encoding="utf-8"?>
<root>
  <object dataType="Class" type="Duality.Resources.Scene">
    <globalGravity dataType="Struct" type="OpenTK.Vector2">
      <X dataType="Float">0</X>
      <Y dataType="Float">0</Y>
    </globalGravity>
    <serializeObj dataType="Array" type="Duality.GameObject[]" id="292984781" length="2">
      <object dataType="Class" type="Duality.GameObject" id="2287365604">
        <name dataType="String">Camera</name>
        <prefabLink />
        <identifier dataType="Struct" type="System.Guid" surrogate="true">
          <header>
            <data dataType="Array" type="System.Byte[]" id="3499011686" length="16">hyDILp4XaE2RVLHtQHCvCw==</data>
          </header>
          <body />
        </identifier>
        <parent />
        <children />
        <compMap dataType="Class" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="2430513090" surrogate="true">
          <header />
          <body>
            <keys dataType="Array" type="System.Type[]" id="2225288916" length="2">
              <object dataType="Type" id="528210888" value="Duality.Components.Transform" />
              <object dataType="Type" id="3850113648" value="Duality.Components.Camera" />
            </keys>
            <values dataType="Array" type="Duality.Component[]" id="1279210008" length="2">
              <object dataType="Class" type="Duality.Components.Transform" id="352713240">
                <pos dataType="Struct" type="OpenTK.Vector3">
                  <X dataType="Float">150</X>
                  <Y dataType="Float">125</Y>
                  <Z dataType="Float">-500</Z>
                </pos>
                <angle dataType="Float">0</angle>
                <scale dataType="Float">1</scale>
                <deriveAngle dataType="Bool">true</deriveAngle>
                <ignoreParent dataType="Bool">false</ignoreParent>
                <parentTransform />
                <posAbs dataType="Struct" type="OpenTK.Vector3">
                  <X dataType="Float">150</X>
                  <Y dataType="Float">125</Y>
                  <Z dataType="Float">-500</Z>
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
                <gameobj dataType="ObjectRef">2287365604</gameobj>
                <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                <active dataType="Bool">true</active>
              </object>
              <object dataType="Class" type="Duality.Components.Camera" id="2824641411">
                <nearZ dataType="Float">1</nearZ>
                <farZ dataType="Float">10000</farZ>
                <focusDist dataType="Float">500</focusDist>
                <perspective dataType="Enum" type="Duality.PerspectiveMode" name="Flat" value="0" />
                <visibilityMask dataType="Enum" type="Duality.VisibilityFlag" name="All" value="4294967295" />
                <passes dataType="Class" type="System.Collections.Generic.List`1[[Duality.Components.Camera+Pass]]" id="1563312295">
                  <_items dataType="Array" type="Duality.Components.Camera+Pass[]" id="4136442186" length="8">
                    <object dataType="Class" type="Duality.Components.Camera+Pass" id="306494500">
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
                    <object dataType="Class" type="Duality.Components.Camera+Pass" id="2536541240">
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
                    <object />
                    <object />
                    <object />
                    <object />
                  </_items>
                  <_size dataType="Int">2</_size>
                  <_version dataType="Int">206</_version>
                </passes>
                <gameobj dataType="ObjectRef">2287365604</gameobj>
                <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                <active dataType="Bool">true</active>
              </object>
            </values>
          </body>
        </compMap>
        <compList dataType="Class" type="System.Collections.Generic.List`1[[Duality.Component]]" id="4136796764">
          <_items dataType="Array" type="Duality.Component[]" id="466027834" length="4">
            <object dataType="ObjectRef">352713240</object>
            <object dataType="ObjectRef">2824641411</object>
            <object />
            <object />
          </_items>
          <_size dataType="Int">2</_size>
          <_version dataType="Int">2</_version>
        </compList>
        <active dataType="Bool">true</active>
        <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
        <compTransform dataType="ObjectRef">352713240</compTransform>
      </object>
      <object dataType="Class" type="Duality.GameObject" id="2486722750">
        <name dataType="String">Background</name>
        <prefabLink />
        <identifier dataType="Struct" type="System.Guid" surrogate="true">
          <header>
            <data dataType="Array" type="System.Byte[]" id="978762680" length="16">PCPHfv+4SUOPFFIl4mDPyw==</data>
          </header>
          <body />
        </identifier>
        <parent />
        <children />
        <compMap dataType="Class" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="3632302184" surrogate="true">
          <header />
          <body>
            <keys dataType="Array" type="System.Type[]" id="1725745424" length="3">
              <object dataType="ObjectRef">528210888</object>
              <object dataType="Type" id="3600105120" value="Duality.Components.Renderers.SpriteRenderer" />
              <object dataType="Type" id="2497880256" value="Engine.Components.ResolutionUpdateComponent" />
            </keys>
            <values dataType="Array" type="Duality.Component[]" id="3665783520" length="3">
              <object dataType="Class" type="Duality.Components.Transform" id="552070386">
                <pos dataType="Struct" type="OpenTK.Vector3">
                  <X dataType="Float">150</X>
                  <Y dataType="Float">125</Y>
                  <Z dataType="Float">0</Z>
                </pos>
                <angle dataType="Float">0</angle>
                <scale dataType="Float">1</scale>
                <deriveAngle dataType="Bool">true</deriveAngle>
                <ignoreParent dataType="Bool">false</ignoreParent>
                <parentTransform />
                <posAbs dataType="Struct" type="OpenTK.Vector3">
                  <X dataType="Float">150</X>
                  <Y dataType="Float">125</Y>
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
                <gameobj dataType="ObjectRef">2486722750</gameobj>
                <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                <active dataType="Bool">true</active>
              </object>
              <object dataType="Class" type="Duality.Components.Renderers.SpriteRenderer" id="4128889318">
                <rect dataType="Struct" type="Duality.Rect">
                  <X dataType="Float">-150</X>
                  <Y dataType="Float">-125</Y>
                  <W dataType="Float">300</W>
                  <H dataType="Float">250</H>
                </rect>
                <sharedMat dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Material]]">
                  <contentPath dataType="String">Data\Sprites\Desert.Material.res</contentPath>
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
                <gameobj dataType="ObjectRef">2486722750</gameobj>
                <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                <active dataType="Bool">true</active>
              </object>
              <object dataType="Class" type="Engine.Components.ResolutionUpdateComponent" id="3415110484">
                <resWidth dataType="Float">0</resWidth>
                <resHeight dataType="Float">0</resHeight>
                <startingRect dataType="Struct" type="Duality.Rect">
                  <X dataType="Float">0</X>
                  <Y dataType="Float">0</Y>
                  <W dataType="Float">0</W>
                  <H dataType="Float">0</H>
                </startingRect>
                <resNormalWidth dataType="Float">600</resNormalWidth>
                <resNormalHeight dataType="Float">800</resNormalHeight>
                <scale dataType="Float">1</scale>
                <fullWindow dataType="Bool">true</fullWindow>
                <gameobj dataType="ObjectRef">2486722750</gameobj>
                <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                <active dataType="Bool">true</active>
              </object>
            </values>
          </body>
        </compMap>
        <compList dataType="Class" type="System.Collections.Generic.List`1[[Duality.Component]]" id="3268803760">
          <_items dataType="Array" type="Duality.Component[]" id="1794918280" length="4">
            <object dataType="ObjectRef">552070386</object>
            <object dataType="ObjectRef">4128889318</object>
            <object dataType="ObjectRef">3415110484</object>
            <object />
          </_items>
          <_size dataType="Int">3</_size>
          <_version dataType="Int">3</_version>
        </compList>
        <active dataType="Bool">true</active>
        <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
        <compTransform dataType="ObjectRef">552070386</compTransform>
      </object>
    </serializeObj>
    <sourcePath />
  </object>
</root>