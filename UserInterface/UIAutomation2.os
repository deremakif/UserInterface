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
    <OpenSpan.Automation.Automator Name="UIAutomation2" Id="Automator-8D66CB7DE1E6DBE">
      <AutomationDocument>
        <Name Value="" />
        <Size Value="5000, 5000" />
        <Objects>
          <ConnectionBlock>
            <DisplayName Value="Activity.ActivityStarted" />
            <ConnectableUniqueId Value="Automator-8D66CB7DE1E6DBE\ConnectableEvent-8D66CB7F4B356C5" />
            <PartID Value="1" />
            <Left Value="20" />
            <Top Value="20" />
            <Collapsed Value="True" />
            <WillExecute Value="True" />
            <InstanceName Value="UpdateInfo" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="Properties" />
            <ConnectableUniqueId Value="Automator-8D66CB7DE1E6DBE\ConnectableProperties-8D66CB808684996" />
            <PartID Value="2" />
            <Left Value="180" />
            <Top Value="20" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="ınteractionManager1" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="Properties" />
            <ConnectableUniqueId Value="Automator-8D66CB7DE1E6DBE\ConnectableProperties-8D66CB840EAD17D" />
            <PartID Value="4" />
            <Left Value="380" />
            <Top Value="0" />
            <Collapsed Value="False" />
            <WillExecute Value="False" />
            <InstanceName Value="txtAddress" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="Properties" />
            <ConnectableUniqueId Value="Automator-8D66CB7DE1E6DBE\ConnectableProperties-8D66CB844A302CC" />
            <PartID Value="5" />
            <Left Value="440" />
            <Top Value="60" />
            <Collapsed Value="False" />
            <WillExecute Value="False" />
            <InstanceName Value="txtCity" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="Properties" />
            <ConnectableUniqueId Value="Automator-8D66CB7DE1E6DBE\ConnectableProperties-8D66CB8471C7CA5" />
            <PartID Value="6" />
            <Left Value="440" />
            <Top Value="120" />
            <Collapsed Value="False" />
            <WillExecute Value="False" />
            <InstanceName Value="txtName" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="Properties" />
            <ConnectableUniqueId Value="Automator-8D66CB7DE1E6DBE\ConnectableProperties-8D66CB849716F43" />
            <PartID Value="7" />
            <Left Value="440" />
            <Top Value="180" />
            <Collapsed Value="False" />
            <WillExecute Value="False" />
            <InstanceName Value="txtState" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="Properties" />
            <ConnectableUniqueId Value="Automator-8D66CB7DE1E6DBE\ConnectableProperties-8D66CB84C120342" />
            <PartID Value="8" />
            <Left Value="380" />
            <Top Value="240" />
            <Collapsed Value="False" />
            <WillExecute Value="False" />
            <InstanceName Value="txtZip" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="Properties" />
            <ConnectableUniqueId Value="Automator-8D66CB7DE1E6DBE\ConnectableProperties-8D66CBB07BB1FE8" />
            <PartID Value="14" />
            <Left Value="0" />
            <Top Value="80" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="cmbAccountNo" />
            <OverriddenIds />
          </ConnectionBlock>
        </Objects>
        <Links>
          <Link PartID="3" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="1" PortName="Raised" PortType="Event" ConnectableId="Automator-8D66CB7DE1E6DBE\ConnectableEvent-8D66CB7F4B356C5" MemberComponentId="Automator-8D66CB7DE1E6DBE\EMPTY" />
            <To PartID="2" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D66CB7DE1E6DBE\ConnectableProperties-8D66CB808684996" MemberComponentId="Automator-8D66CB7DE1E6DBE\ConnectableProperties-8D66CB808684996" />
            <LinkPoints>
              <Point value="153, 49" />
              <Point value="163, 49" />
              <Point value="169, 49" />
              <Point value="169, 49" />
              <Point value="175, 49" />
              <Point value="185, 49" />
            </LinkPoints>
          </Link>
          <Link PartID="9" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="2" PortName="Address" PortType="Property" ConnectableId="Automator-8D66CB7DE1E6DBE\ConnectableProperties-8D66CB808684996" MemberComponentId="GlobalContainer-8D66C51F4CAC0FC\InteractionManager-8D66C52238E76D0" />
            <To PartID="4" PortName="Text" PortType="Property" ConnectableId="Automator-8D66CB7DE1E6DBE\ConnectableProperties-8D66CB840EAD17D" MemberComponentId="DesignForm-8D66C4BE51297C5\TextBox-8D66C4C6CA996A9" />
            <LinkPoints>
              <Point value="355, 117" />
              <Point value="365, 117" />
              <Point value="365, 117" />
              <Point value="365, 46" />
              <Point value="375, 46" />
              <Point value="385, 46" />
            </LinkPoints>
          </Link>
          <Link PartID="10" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="2" PortName="City" PortType="Property" ConnectableId="Automator-8D66CB7DE1E6DBE\ConnectableProperties-8D66CB808684996" MemberComponentId="GlobalContainer-8D66C51F4CAC0FC\InteractionManager-8D66C52238E76D0" />
            <To PartID="5" PortName="Text" PortType="Property" ConnectableId="Automator-8D66CB7DE1E6DBE\ConnectableProperties-8D66CB844A302CC" MemberComponentId="DesignForm-8D66C4BE51297C5\TextBox-8D66C4C6FB73F63" />
            <LinkPoints>
              <Point value="355, 134" />
              <Point value="365, 134" />
              <Point value="365, 134" />
              <Point value="365, 106" />
              <Point value="435, 106" />
              <Point value="445, 106" />
            </LinkPoints>
          </Link>
          <Link PartID="11" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="2" PortName="Name" PortType="Property" ConnectableId="Automator-8D66CB7DE1E6DBE\ConnectableProperties-8D66CB808684996" MemberComponentId="GlobalContainer-8D66C51F4CAC0FC\InteractionManager-8D66C52238E76D0" />
            <To PartID="6" PortName="Text" PortType="Property" ConnectableId="Automator-8D66CB7DE1E6DBE\ConnectableProperties-8D66CB8471C7CA5" MemberComponentId="DesignForm-8D66C4BE51297C5\TextBox-8D66C4C081BB5B1" />
            <LinkPoints>
              <Point value="355, 151" />
              <Point value="365, 151" />
              <Point value="365, 151" />
              <Point value="365, 166" />
              <Point value="435, 166" />
              <Point value="445, 166" />
            </LinkPoints>
          </Link>
          <Link PartID="12" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="2" PortName="State" PortType="Property" ConnectableId="Automator-8D66CB7DE1E6DBE\ConnectableProperties-8D66CB808684996" MemberComponentId="GlobalContainer-8D66C51F4CAC0FC\InteractionManager-8D66C52238E76D0" />
            <To PartID="7" PortName="Text" PortType="Property" ConnectableId="Automator-8D66CB7DE1E6DBE\ConnectableProperties-8D66CB849716F43" MemberComponentId="DesignForm-8D66C4BE51297C5\TextBox-8D66C4C72B6CB56" />
            <LinkPoints>
              <Point value="355, 168" />
              <Point value="365, 168" />
              <Point value="365, 168" />
              <Point value="365, 226" />
              <Point value="435, 226" />
              <Point value="445, 226" />
            </LinkPoints>
          </Link>
          <Link PartID="13" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="2" PortName="Zipcode" PortType="Property" ConnectableId="Automator-8D66CB7DE1E6DBE\ConnectableProperties-8D66CB808684996" MemberComponentId="GlobalContainer-8D66C51F4CAC0FC\InteractionManager-8D66C52238E76D0" />
            <To PartID="8" PortName="Text" PortType="Property" ConnectableId="Automator-8D66CB7DE1E6DBE\ConnectableProperties-8D66CB84C120342" MemberComponentId="DesignForm-8D66C4BE51297C5\TextBox-8D66C4E198DB838" />
            <LinkPoints>
              <Point value="355, 185" />
              <Point value="365, 185" />
              <Point value="365, 185" />
              <Point value="365, 286" />
              <Point value="375, 286" />
              <Point value="385, 286" />
            </LinkPoints>
          </Link>
          <Link PartID="15" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="14" PortName="Text" PortType="Property" ConnectableId="Automator-8D66CB7DE1E6DBE\ConnectableProperties-8D66CBB07BB1FE8" MemberComponentId="DesignForm-8D66C4BE51297C5\ComboBox-8D66C4C1810BB05" />
            <To PartID="2" PortName="_SmartKey%GlobalContainer-8D66C51F4CAC0FC\InteractionManager-8D66C52238E76D0%Key%Value" PortType="Property" ConnectableId="Automator-8D66CB7DE1E6DBE\ConnectableProperties-8D66CB808684996" MemberComponentId="Automator-8D66CB7DE1E6DBE\ConnectableProperties-8D66CB808684996" />
            <LinkPoints>
              <Point value="142, 126" />
              <Point value="152, 126" />
              <Point value="156, 126" />
              <Point value="156, 83" />
              <Point value="175, 83" />
              <Point value="185, 83" />
            </LinkPoints>
          </Link>
        </Links>
        <Comments />
        <SubGraphs />
      </AutomationDocument>
    </OpenSpan.Automation.Automator>
    <OpenSpan.Automation.ConnectableEvent Name="connectableEvent1" Id="ConnectableEvent-8D66CB7F4B356C5">
      <ComponentName Value="UpdateInfo" />
      <DisplayName Value="Activity.ActivityStarted" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Interactions.Controls.Activity" />
      <InstanceUniqueId Value="GlobalContainer-8D66C51F4CAC0FC\Activity-8D66CB221FFF252" />
      <MemberDetails Value=".ActivityStarted Event" />
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="ActivityStarted" />
            <MemberType Value="Event" />
            <TypeName Value="System.EventHandler`1[[OpenSpan.Interactions.ActivityEventArgs, OpenSpan.Interactions, Version=8.0.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e]]" />
          </OpenSpan.Automation.MemberPrototype>
        </Items>
      </Content>
    </OpenSpan.Automation.ConnectableEvent>
    <OpenSpan.Automation.ConnectableProperties Name="connectableProperties1" Id="ConnectableProperties-8D66CB808684996">
      <ComponentName Value="ınteractionManager1" />
      <DefaultValues Value="" />
      <DisplayName Value="Properties" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Interactions.Controls.InteractionManager" />
      <InstanceUniqueId Value="GlobalContainer-8D66C51F4CAC0FC\InteractionManager-8D66C52238E76D0" />
      <MemberDetails Value=" - Properties(ActNum, Address, City, Name, State, Zipcode)" />
      <Content Name="DynamicMembers">
        <Items>
          <OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicType="Property" name="_SmartKey%GlobalContainer-8D66C51F4CAC0FC\InteractionManager-8D66C52238E76D0%Key%Value" canRead="False" canWrite="True" type="System.String" aliasName="_SmartKey%GlobalContainer-8D66C51F4CAC0FC\InteractionManager-8D66C52238E76D0%Key%Value" shouldSerialize="False" visibility="DefaultOn" source="" blockTypeName="" />
        </Items>
      </Content>
      <Content Name="KeyInfos">
        <Items>
          <OpenSpan.Automation.KeyInfo>
            <CloneContextId Value="GlobalContainer-8D66C51F4CAC0FC\InteractionManager-8D66C52238E76D0" />
            <KeyName Value="Key" />
            <KeyObjectTypeName Value="OpenSpan.Interactions.Controls.InteractionKey" />
            <KeyType Value="Smart" />
            <SetUpstream Value="False" />
          </OpenSpan.Automation.KeyInfo>
        </Items>
      </Content>
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="ActNum" />
            <MemberType Value="Property" />
            <TypeName Value="System.Double" />
          </OpenSpan.Automation.MemberPrototype>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="Address" />
            <MemberType Value="Property" />
            <TypeName Value="System.String" />
          </OpenSpan.Automation.MemberPrototype>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="City" />
            <MemberType Value="Property" />
            <TypeName Value="System.String" />
          </OpenSpan.Automation.MemberPrototype>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="Name" />
            <MemberType Value="Property" />
            <TypeName Value="System.String" />
          </OpenSpan.Automation.MemberPrototype>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="State" />
            <MemberType Value="Property" />
            <TypeName Value="System.String" />
          </OpenSpan.Automation.MemberPrototype>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="Zipcode" />
            <MemberType Value="Property" />
            <TypeName Value="System.String" />
          </OpenSpan.Automation.MemberPrototype>
        </Items>
      </Content>
    </OpenSpan.Automation.ConnectableProperties>
    <OpenSpan.Automation.ConnectableProperties Name="connectableProperties2" Id="ConnectableProperties-8D66CB840EAD17D">
      <ComponentName Value="txtAddress" />
      <DefaultValues Value="" />
      <DisplayName Value="Properties" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="System.Windows.Forms.TextBox" />
      <InstanceUniqueId Value="DesignForm-8D66C4BE51297C5\TextBox-8D66C4C6CA996A9" />
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
    <OpenSpan.Automation.ConnectableProperties Name="connectableProperties3" Id="ConnectableProperties-8D66CB844A302CC">
      <ComponentName Value="txtCity" />
      <DefaultValues Value="" />
      <DisplayName Value="Properties" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="System.Windows.Forms.TextBox" />
      <InstanceUniqueId Value="DesignForm-8D66C4BE51297C5\TextBox-8D66C4C6FB73F63" />
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
    <OpenSpan.Automation.ConnectableProperties Name="connectableProperties4" Id="ConnectableProperties-8D66CB8471C7CA5">
      <ComponentName Value="txtName" />
      <DefaultValues Value="" />
      <DisplayName Value="Properties" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="System.Windows.Forms.TextBox" />
      <InstanceUniqueId Value="DesignForm-8D66C4BE51297C5\TextBox-8D66C4C081BB5B1" />
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
    <OpenSpan.Automation.ConnectableProperties Name="connectableProperties5" Id="ConnectableProperties-8D66CB849716F43">
      <ComponentName Value="txtState" />
      <DefaultValues Value="" />
      <DisplayName Value="Properties" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="System.Windows.Forms.TextBox" />
      <InstanceUniqueId Value="DesignForm-8D66C4BE51297C5\TextBox-8D66C4C72B6CB56" />
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
    <OpenSpan.Automation.ConnectableProperties Name="connectableProperties6" Id="ConnectableProperties-8D66CB84C120342">
      <ComponentName Value="txtZip" />
      <DefaultValues Value="" />
      <DisplayName Value="Properties" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="System.Windows.Forms.TextBox" />
      <InstanceUniqueId Value="DesignForm-8D66C4BE51297C5\TextBox-8D66C4E198DB838" />
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
    <OpenSpan.Automation.ConnectableProperties Name="connectableProperties7" Id="ConnectableProperties-8D66CBB07BB1FE8">
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