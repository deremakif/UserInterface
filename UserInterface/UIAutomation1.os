<OpenSpanDesignDocument Version="8.0.1026.0" Serializer="2.0" Culture="tr-TR">
  <ComponentInfo>
    <Type Value="OpenSpan.Automation.Automator" />
    <Assembly Value="OpenSpan.Automation" />
    <AssemblyReferences>
      <Assembly Value="System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
      <Assembly Value="mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
      <Assembly Value="OpenSpan, Version=8.0.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="OpenSpan.Automation, Version=8.0.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="OpenSpan.Interactions.Controls, Version=8.0.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
    </AssemblyReferences>
    <DynamicAssemblyReferences />
    <FileReferences />
    <BuildReferences />
  </ComponentInfo>
  <Component Version="1.0">
    <OpenSpan.Automation.Automator Name="UIAutomation1" Id="Automator-8D66CB1D8006848">
      <AutomationDocument>
        <Name Value="" />
        <Size Value="5000, 5000" />
        <Objects>
          <ConnectionBlock>
            <DisplayName Value="InteractionManager.InteractionActivated" />
            <ConnectableUniqueId Value="Automator-8D66CB1D8006848\ConnectableEvent-8D66CB2017B96E3" />
            <PartID Value="1" />
            <Left Value="20" />
            <Top Value="40" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="ınteractionManager1" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="Add" />
            <ConnectableUniqueId Value="Automator-8D66CB1D8006848\ConnectableMethod-8D66CB272905F12" />
            <PartID Value="2" />
            <Left Value="240" />
            <Top Value="40" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="cmbAccountNo.Items" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="ComboBox.SelectedIndexChanged" />
            <ConnectableUniqueId Value="Automator-8D66CB1D8006848\ConnectableEvent-8D66CB2ADCD4087" />
            <PartID Value="5" />
            <Left Value="20" />
            <Top Value="140" />
            <Collapsed Value="True" />
            <WillExecute Value="True" />
            <InstanceName Value="cmbAccountNo" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="StartActivityForKey" />
            <ConnectableUniqueId Value="Automator-8D66CB1D8006848\ConnectableMethod-8D66CB3026D06B9" />
            <PartID Value="6" />
            <Left Value="240" />
            <Top Value="140" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="ActivateWindow" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="Properties" />
            <ConnectableUniqueId Value="Automator-8D66CB1D8006848\ConnectableProperties-8D66CB30FE43B79" />
            <PartID Value="7" />
            <Left Value="20" />
            <Top Value="200" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="cmbAccountNo" />
            <OverriddenIds />
          </ConnectionBlock>
        </Objects>
        <Links>
          <Link PartID="3" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="1" PortName="Key" PortType="Property" ConnectableId="Automator-8D66CB1D8006848\ConnectableEvent-8D66CB2017B96E3" MemberComponentId="Automator-8D66CB1D8006848\EMPTY" />
            <To PartID="2" PortName="item" PortType="Property" ConnectableId="Automator-8D66CB1D8006848\ConnectableMethod-8D66CB272905F12" MemberComponentId="Automator-8D66CB1D8006848\ConnectableMethod-8D66CB272905F12" />
            <LinkPoints>
              <Point value="195, 103" />
              <Point value="205, 103" />
              <Point value="205, 103" />
              <Point value="205, 86" />
              <Point value="235, 86" />
              <Point value="245, 86" />
            </LinkPoints>
          </Link>
          <Link PartID="4" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="1" PortName="Raised" PortType="Event" ConnectableId="Automator-8D66CB1D8006848\ConnectableEvent-8D66CB2017B96E3" MemberComponentId="Automator-8D66CB1D8006848\EMPTY" />
            <To PartID="2" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D66CB1D8006848\ConnectableMethod-8D66CB272905F12" MemberComponentId="Automator-8D66CB1D8006848\ConnectableMethod-8D66CB272905F12" />
            <LinkPoints>
              <Point value="195, 69" />
              <Point value="205, 69" />
              <Point value="220, 69" />
              <Point value="220, 69" />
              <Point value="235, 69" />
              <Point value="245, 69" />
            </LinkPoints>
          </Link>
          <Link PartID="8" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="5" PortName="Raised" PortType="Event" ConnectableId="Automator-8D66CB1D8006848\ConnectableEvent-8D66CB2ADCD4087" MemberComponentId="Automator-8D66CB1D8006848\EMPTY" />
            <To PartID="6" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D66CB1D8006848\ConnectableMethod-8D66CB3026D06B9" MemberComponentId="Automator-8D66CB1D8006848\ConnectableMethod-8D66CB3026D06B9" />
            <LinkPoints>
              <Point value="207, 169" />
              <Point value="217, 169" />
              <Point value="226, 169" />
              <Point value="226, 169" />
              <Point value="235, 169" />
              <Point value="245, 169" />
            </LinkPoints>
          </Link>
          <Link PartID="9" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="7" PortName="Text" PortType="Property" ConnectableId="Automator-8D66CB1D8006848\ConnectableProperties-8D66CB30FE43B79" MemberComponentId="DesignForm-8D66C4BE51297C5\ComboBox-8D66C4C1810BB05" />
            <To PartID="6" PortName="interactionKey" PortType="Property" ConnectableId="Automator-8D66CB1D8006848\ConnectableMethod-8D66CB3026D06B9" MemberComponentId="Automator-8D66CB1D8006848\ConnectableMethod-8D66CB3026D06B9" />
            <LinkPoints>
              <Point value="162, 246" />
              <Point value="172, 246" />
              <Point value="172, 246" />
              <Point value="172, 186" />
              <Point value="235, 186" />
              <Point value="245, 186" />
            </LinkPoints>
          </Link>
          <Link PartID="10" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="7" PortName="Text" PortType="Property" ConnectableId="Automator-8D66CB1D8006848\ConnectableProperties-8D66CB30FE43B79" MemberComponentId="DesignForm-8D66C4BE51297C5\ComboBox-8D66C4C1810BB05" />
            <To PartID="6" PortName="AccountNumber" PortType="Property" ConnectableId="Automator-8D66CB1D8006848\ConnectableMethod-8D66CB3026D06B9" MemberComponentId="Automator-8D66CB1D8006848\ConnectableMethod-8D66CB3026D06B9" />
            <LinkPoints>
              <Point value="162, 246" />
              <Point value="172, 246" />
              <Point value="172, 246" />
              <Point value="172, 203" />
              <Point value="235, 203" />
              <Point value="245, 203" />
            </LinkPoints>
          </Link>
        </Links>
        <Comments />
        <SubGraphs />
      </AutomationDocument>
    </OpenSpan.Automation.Automator>
    <OpenSpan.Automation.ConnectableEvent Name="connectableEvent1" Id="ConnectableEvent-8D66CB2017B96E3">
      <ComponentName Value="ınteractionManager1" />
      <DisplayName Value="InteractionManager.InteractionActivated" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Interactions.Controls.InteractionManager" />
      <InstanceUniqueId Value="GlobalContainer-8D66C51F4CAC0FC\InteractionManager-8D66C52238E76D0" />
      <MemberDetails Value=".InteractionActivated Event" />
      <Content Name="KeyInfos">
        <Items>
          <OpenSpan.Automation.KeyInfo>
            <CloneContextId Value="GlobalContainer-8D66C51F4CAC0FC\InteractionManager-8D66C52238E76D0" />
            <KeyName Value="None" />
            <KeyType Value="Normal" />
            <SetUpstream Value="False" />
          </OpenSpan.Automation.KeyInfo>
        </Items>
      </Content>
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="InteractionActivated" />
            <MemberType Value="Event" />
            <TypeName Value="System.EventHandler`1[[OpenSpan.Interactions.InteractionEventArgs, OpenSpan.Interactions, Version=8.0.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e]]" />
          </OpenSpan.Automation.MemberPrototype>
        </Items>
      </Content>
    </OpenSpan.Automation.ConnectableEvent>
    <OpenSpan.Automation.ConnectableMethod Name="connectableMethod1" Id="ConnectableMethod-8D66CB272905F12">
      <ComponentName Value="cmbAccountNo" />
      <DisplayName Value="Add" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="System.Windows.Forms.ComboBox+ObjectCollection" />
      <InstanceUniqueId Value="DesignForm-8D66C4BE51297C5\ComboBox-8D66C4C1810BB05" />
      <MemberDetails Value=".Add() Method" />
      <ParamsLength Value="0" />
      <SerializedParamsDefaultValues Value="" />
      <SubProperty Value="Items" />
      <Content Name="DynamicMembers">
        <Items>
          <OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicType="Property" name="Result" canRead="True" canWrite="False" type="System.Int32" aliasName="Result" shouldSerialize="False" visibility="DefaultOn" source="" blockTypeName="" />
        </Items>
      </Content>
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="Add" />
            <MemberType Value="Method" />
            <TypeName Value="System.Int32" />
            <Content Name="Signature">
              <OpenSpan.Automation.MethodSignature>
                <ReturnType Value="System.Int32" />
                <Content Name="ParameterPrototype">
                  <Items>
                    <OpenSpan.Automation.ParameterPrototype>
                      <CanRead Value="False" />
                      <CanWrite Value="True" />
                      <DefaultSet Value="False" />
                      <ParamName Value="item" />
                      <Position Value="0" />
                      <TypeName Value="System.Object" />
                    </OpenSpan.Automation.ParameterPrototype>
                  </Items>
                </Content>
              </OpenSpan.Automation.MethodSignature>
            </Content>
          </OpenSpan.Automation.MemberPrototype>
        </Items>
      </Content>
    </OpenSpan.Automation.ConnectableMethod>
    <OpenSpan.Automation.ConnectableEvent Name="connectableEvent2" Id="ConnectableEvent-8D66CB2ADCD4087">
      <ComponentName Value="cmbAccountNo" />
      <DisplayName Value="ComboBox.SelectedIndexChanged" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="System.Windows.Forms.ComboBox" />
      <InstanceUniqueId Value="DesignForm-8D66C4BE51297C5\ComboBox-8D66C4C1810BB05" />
      <MemberDetails Value=".SelectedIndexChanged Event" />
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="SelectedIndexChanged" />
            <MemberType Value="Event" />
            <TypeName Value="System.EventHandler" />
          </OpenSpan.Automation.MemberPrototype>
        </Items>
      </Content>
    </OpenSpan.Automation.ConnectableEvent>
    <OpenSpan.Automation.ConnectableMethod Name="connectableMethod2" Id="ConnectableMethod-8D66CB3026D06B9">
      <ComponentName Value="ActivateWindow" />
      <DisplayName Value="StartActivityForKey" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Interactions.Controls.Activity" />
      <InstanceUniqueId Value="GlobalContainer-8D66C51F4CAC0FC\Activity-8D66CB2C8BC3813" />
      <MemberDetails Value=".StartActivityForKey() Method" />
      <ParamsLength Value="0" />
      <SerializedParamsDefaultValues Value="" />
      <Content Name="DynamicMembers">
        <Items>
          <OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicType="Property" name="Result" canRead="True" canWrite="False" type="System.Int32" aliasName="Result" shouldSerialize="False" visibility="DefaultOn" source="" blockTypeName="" />
        </Items>
      </Content>
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="StartActivityForKey" />
            <MemberType Value="Method" />
            <TypeName Value="System.Int32" />
            <Content Name="Signature">
              <OpenSpan.Automation.MethodSignature>
                <ReturnType Value="System.Int32" />
                <Content Name="ParameterPrototype">
                  <Items>
                    <OpenSpan.Automation.ParameterPrototype>
                      <CanRead Value="False" />
                      <CanWrite Value="True" />
                      <DefaultSet Value="False" />
                      <ParamName Value="interactionKey" />
                      <Position Value="0" />
                      <TypeName Value="System.String" />
                    </OpenSpan.Automation.ParameterPrototype>
                    <OpenSpan.Automation.ParameterPrototype>
                      <CanRead Value="False" />
                      <CanWrite Value="True" />
                      <DefaultSet Value="False" />
                      <ParamName Value="AccountNumber" />
                      <Position Value="1" />
                      <TypeName Value="System.String" />
                    </OpenSpan.Automation.ParameterPrototype>
                    <OpenSpan.Automation.ParameterPrototype>
                      <CanRead Value="False" />
                      <CanWrite Value="True" />
                      <DefaultSet Value="False" />
                      <ParamName Value="maxExecutionTime" />
                      <Position Value="2" />
                      <TypeName Value="System.Int32" />
                    </OpenSpan.Automation.ParameterPrototype>
                  </Items>
                </Content>
              </OpenSpan.Automation.MethodSignature>
            </Content>
          </OpenSpan.Automation.MemberPrototype>
        </Items>
      </Content>
    </OpenSpan.Automation.ConnectableMethod>
    <OpenSpan.Automation.ConnectableProperties Name="connectableProperties1" Id="ConnectableProperties-8D66CB30FE43B79">
      <ComponentName Value="cmbAccountNo" />
      <DefaultValues Value="" />
      <DisplayName Value="Properties" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="System.Windows.Forms.ComboBox" />
      <InstanceUniqueId Value="DesignForm-8D66C4BE51297C5\ComboBox-8D66C4C1810BB05" />
      <MemberDetails Value=".Text Property" />
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="Text" />
            <MemberType Value="Property" />
            <TypeName Value="System.String" />
          </OpenSpan.Automation.MemberPrototype>
        </Items>
      </Content>
    </OpenSpan.Automation.ConnectableProperties>
  </Component>
</OpenSpanDesignDocument>