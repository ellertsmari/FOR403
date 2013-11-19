<?xml version="1.0" encoding="utf-8"?>
<root>
  <object dataType="Class" type="Duality.Resources.Prefab">
    <objTree dataType="Class" type="Duality.GameObject" id="2204305144">
      <name dataType="String">Tile</name>
      <prefabLink />
      <identifier dataType="Struct" type="System.Guid" surrogate="true">
        <header>
          <data dataType="Array" type="System.Byte[]" id="3278664109" length="16">U0WWsfVElEOxqXYy8ILWPw==</data>
        </header>
        <body />
      </identifier>
      <parent />
      <children />
      <compMap dataType="Class" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="927385535" surrogate="true">
        <header />
        <body>
          <keys dataType="Array" type="System.Type[]" id="2129482154" length="2">
            <object dataType="Type" id="2927528932" value="Duality.Components.Transform" />
            <object dataType="Type" id="3987162424" value="Duality.Components.Renderers.AnimSpriteRenderer" />
          </keys>
          <values dataType="Array" type="Duality.Component[]" id="3065463564" length="2">
            <object dataType="Class" type="Duality.Components.Transform" id="269652780">
              <pos dataType="Struct" type="OpenTK.Vector3">
                <X dataType="Float">12.5965862</X>
                <Y dataType="Float">-12.4846191</Y>
                <Z dataType="Float">1</Z>
              </pos>
              <angle dataType="Float">0</angle>
              <scale dataType="Float">1</scale>
              <deriveAngle dataType="Bool">true</deriveAngle>
              <ignoreParent dataType="Bool">false</ignoreParent>
              <parentTransform />
              <posAbs dataType="Struct" type="OpenTK.Vector3">
                <X dataType="Float">12.5965862</X>
                <Y dataType="Float">-12.4846191</Y>
                <Z dataType="Float">1</Z>
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
              <gameobj dataType="ObjectRef">2204305144</gameobj>
              <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
              <active dataType="Bool">true</active>
            </object>
            <object dataType="Class" type="Duality.Components.Renderers.AnimSpriteRenderer" id="1911740525">
              <animFirstFrame dataType="Int">0</animFirstFrame>
              <animFrameCount dataType="Int">121</animFrameCount>
              <animDuration dataType="Float">5</animDuration>
              <animLoopMode dataType="Enum" type="Duality.Components.Renderers.AnimSpriteRenderer+LoopMode" name="Once" value="0" />
              <animTime dataType="Float">0</animTime>
              <animPaused dataType="Bool">false</animPaused>
              <customFrameSequence />
              <rect dataType="Struct" type="Duality.Rect">
                <X dataType="Float">-12.5</X>
                <Y dataType="Float">-12.5</Y>
                <W dataType="Float">25</W>
                <H dataType="Float">25</H>
              </rect>
              <sharedMat dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Material]]">
                <contentPath dataType="String">Data\Sprites\TilesetFixed.Material.res</contentPath>
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
              <gameobj dataType="ObjectRef">2204305144</gameobj>
              <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
              <active dataType="Bool">true</active>
            </object>
          </values>
        </body>
      </compMap>
      <compList dataType="Class" type="System.Collections.Generic.List`1[[Duality.Component]]" id="3640236526">
        <_items dataType="Array" type="Duality.Component[]" id="2279971267" length="4">
          <object dataType="ObjectRef">269652780</object>
          <object dataType="ObjectRef">1911740525</object>
          <object />
          <object />
        </_items>
        <_size dataType="Int">2</_size>
        <_version dataType="Int">2</_version>
      </compList>
      <active dataType="Bool">true</active>
      <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
      <compTransform dataType="ObjectRef">269652780</compTransform>
    </objTree>
    <sourcePath dataType="String">Tile</sourcePath>
  </object>
</root>