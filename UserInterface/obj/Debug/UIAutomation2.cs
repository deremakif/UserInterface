using System;

namespace UserInterface
{
/// <summary>
/// OpenSpan design component.
/// </summary>
// Automator-8D66CB7DE1E6DBE
[OpenSpan.Design.ComponentIdentityAttribute("Automator-8D66CB7DE1E6DBE")]
[System.ComponentModel.ToolboxItemAttribute(false)]
[OpenSpan.Runtime.RuntimeReferenceAttribute("System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c5619" +
	"34e089")]
public sealed class UIAutomation2 : OpenSpan.Automation.Automator
{
	
	private OpenSpan.Automation.ConnectableEvent connectableEvent1;
	
	private OpenSpan.Automation.ConnectableProperties connectableProperties1;
	
	private OpenSpan.Automation.ConnectableProperties connectableProperties2;
	
	private OpenSpan.Automation.ConnectableProperties connectableProperties3;
	
	private OpenSpan.Automation.ConnectableProperties connectableProperties4;
	
	private OpenSpan.Automation.ConnectableProperties connectableProperties5;
	
	private OpenSpan.Automation.ConnectableProperties connectableProperties6;
	
	private OpenSpan.Automation.ConnectableProperties connectableProperties7;
	
	public UIAutomation2()
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Setup field members
		// 
		System.ComponentModel.ComponentResourceManager _resources_ = new System.ComponentModel.ComponentResourceManager(typeof(UIAutomation2));
		OpenSpan.Automation.MemberPrototype memberprototype1 = new OpenSpan.Automation.MemberPrototype();
		OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicpropertyinfo1 = new OpenSpan.DynamicMembers.DynamicPropertyInfo();
		OpenSpan.Automation.KeyInfo keyinfo1 = new OpenSpan.Automation.KeyInfo();
		OpenSpan.Automation.MemberPrototype memberprototype2 = new OpenSpan.Automation.MemberPrototype();
		OpenSpan.Automation.MemberPrototype memberprototype3 = new OpenSpan.Automation.MemberPrototype();
		OpenSpan.Automation.MemberPrototype memberprototype4 = new OpenSpan.Automation.MemberPrototype();
		OpenSpan.Automation.MemberPrototype memberprototype5 = new OpenSpan.Automation.MemberPrototype();
		OpenSpan.Automation.MemberPrototype memberprototype6 = new OpenSpan.Automation.MemberPrototype();
		OpenSpan.Automation.MemberPrototype memberprototype7 = new OpenSpan.Automation.MemberPrototype();
		OpenSpan.Automation.MemberPrototype memberprototype8 = new OpenSpan.Automation.MemberPrototype();
		OpenSpan.Automation.MemberPrototype memberprototype9 = new OpenSpan.Automation.MemberPrototype();
		OpenSpan.Automation.MemberPrototype memberprototype10 = new OpenSpan.Automation.MemberPrototype();
		OpenSpan.Automation.MemberPrototype memberprototype11 = new OpenSpan.Automation.MemberPrototype();
		OpenSpan.Automation.MemberPrototype memberprototype12 = new OpenSpan.Automation.MemberPrototype();
		OpenSpan.Automation.MemberPrototype memberprototype13 = new OpenSpan.Automation.MemberPrototype();
		this.connectableEvent1 = new OpenSpan.Automation.ConnectableEvent();
		this.connectableProperties1 = new OpenSpan.Automation.ConnectableProperties();
		this.connectableProperties2 = new OpenSpan.Automation.ConnectableProperties();
		this.connectableProperties3 = new OpenSpan.Automation.ConnectableProperties();
		this.connectableProperties4 = new OpenSpan.Automation.ConnectableProperties();
		this.connectableProperties5 = new OpenSpan.Automation.ConnectableProperties();
		this.connectableProperties6 = new OpenSpan.Automation.ConnectableProperties();
		this.connectableProperties7 = new OpenSpan.Automation.ConnectableProperties();
		// 
		// Initialize design component
		// 
		this.Initialize();
		// 
		// Set design component Id
		// 
		this.Id = new OpenSpan.Design.ComponentIdentity("Automator-8D66CB7DE1E6DBE");
		// 
		// Set component Ids
		// 
		this.SetId(this.connectableEvent1, new OpenSpan.Design.ComponentIdentity("ConnectableEvent-8D66CB7F4B356C5"));
		this.SetId(this.connectableProperties1, new OpenSpan.Design.ComponentIdentity("ConnectableProperties-8D66CB808684996"));
		this.SetId(this.connectableProperties2, new OpenSpan.Design.ComponentIdentity("ConnectableProperties-8D66CB840EAD17D"));
		this.SetId(this.connectableProperties3, new OpenSpan.Design.ComponentIdentity("ConnectableProperties-8D66CB844A302CC"));
		this.SetId(this.connectableProperties4, new OpenSpan.Design.ComponentIdentity("ConnectableProperties-8D66CB8471C7CA5"));
		this.SetId(this.connectableProperties5, new OpenSpan.Design.ComponentIdentity("ConnectableProperties-8D66CB849716F43"));
		this.SetId(this.connectableProperties6, new OpenSpan.Design.ComponentIdentity("ConnectableProperties-8D66CB84C120342"));
		this.SetId(this.connectableProperties7, new OpenSpan.Design.ComponentIdentity("ConnectableProperties-8D66CBB07BB1FE8"));
		// 
		// UIAutomation2
		// 
		ComponentInfo.CodeDomData = _resources_.GetString("_UIAutomation2_1_");
		this.IsStartStoppable = false;
		this.LogData = true;
		this.LogEvents = true;
		this.LogFile = "";
		this.LogToFile = false;
		this.Name = "UIAutomation2";
		this.SuppressErrors = false;
		// 
		// connectableEvent1
		// 
		this.connectableEvent1.DisplayName = "null";
		this.connectableEvent1.ExceptionsHandled = false;
		this.connectableEvent1.InstanceTypeName = "OpenSpan.Interactions.Controls.Activity";
		this.connectableEvent1.InstanceUniqueId = new OpenSpan.Design.ComponentIdentity("GlobalContainer-8D66C51F4CAC0FC\\Activity-8D66CB221FFF252");
		memberprototype1.DefaultValue = null;
		memberprototype1.MemberName = "ActivityStarted";
		memberprototype1.MemberType = System.Reflection.MemberTypes.Event;
		memberprototype1.Signature.ReturnType = null;
		memberprototype1.TypeName = _resources_.GetString("_UIAutomation2_2_");
		this.connectableEvent1.MemberPrototypes.Add(memberprototype1);
		// 
		// connectableProperties1
		// 
		this.connectableProperties1.DefaultValues = "";
		this.connectableProperties1.DisplayName = "Properties";
		dynamicpropertyinfo1.IsSerializable = true;
		dynamicpropertyinfo1.NoInputConvesion = false;
		dynamicpropertyinfo1.Source = "";
		dynamicpropertyinfo1.ValidateConnectionCallback = null;
		dynamicpropertyinfo1.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicpropertyinfo1.CodeDomData = _resources_.GetString("_UIAutomation2_3_");
		this.connectableProperties1.DynamicMembers.Add(dynamicpropertyinfo1);
		this.connectableProperties1.ExceptionsHandled = false;
		this.connectableProperties1.InstanceTypeName = "OpenSpan.Interactions.Controls.InteractionManager";
		this.connectableProperties1.InstanceUniqueId = new OpenSpan.Design.ComponentIdentity("GlobalContainer-8D66C51F4CAC0FC\\InteractionManager-8D66C52238E76D0");
		keyinfo1.CloneContextId = new OpenSpan.Design.ComponentIdentity("GlobalContainer-8D66C51F4CAC0FC\\InteractionManager-8D66C52238E76D0");
		keyinfo1.KeyName = "Key";
		keyinfo1.KeyObjectTypeName = "OpenSpan.Interactions.Controls.InteractionKey";
		keyinfo1.KeyType = OpenSpan.Automation.CloneKeyType.Smart;
		keyinfo1.SetUpstream = false;
		keyinfo1.TokenizedText = null;
		this.connectableProperties1.KeyInfos.Add(keyinfo1);
		memberprototype2.DefaultValue = null;
		memberprototype2.MemberName = "ActNum";
		memberprototype2.MemberType = System.Reflection.MemberTypes.Property;
		memberprototype2.Signature.ReturnType = null;
		memberprototype2.TypeName = "System.Double";
		memberprototype3.DefaultValue = null;
		memberprototype3.MemberName = "Address";
		memberprototype3.MemberType = System.Reflection.MemberTypes.Property;
		memberprototype3.Signature.ReturnType = null;
		memberprototype3.TypeName = "System.String";
		memberprototype4.DefaultValue = null;
		memberprototype4.MemberName = "City";
		memberprototype4.MemberType = System.Reflection.MemberTypes.Property;
		memberprototype4.Signature.ReturnType = null;
		memberprototype4.TypeName = "System.String";
		memberprototype5.DefaultValue = null;
		memberprototype5.MemberName = "Name";
		memberprototype5.MemberType = System.Reflection.MemberTypes.Property;
		memberprototype5.Signature.ReturnType = null;
		memberprototype5.TypeName = "System.String";
		memberprototype6.DefaultValue = null;
		memberprototype6.MemberName = "State";
		memberprototype6.MemberType = System.Reflection.MemberTypes.Property;
		memberprototype6.Signature.ReturnType = null;
		memberprototype6.TypeName = "System.String";
		memberprototype7.DefaultValue = null;
		memberprototype7.MemberName = "Zipcode";
		memberprototype7.MemberType = System.Reflection.MemberTypes.Property;
		memberprototype7.Signature.ReturnType = null;
		memberprototype7.TypeName = "System.String";
		this.connectableProperties1.MemberPrototypes.Add(memberprototype2);
		this.connectableProperties1.MemberPrototypes.Add(memberprototype3);
		this.connectableProperties1.MemberPrototypes.Add(memberprototype4);
		this.connectableProperties1.MemberPrototypes.Add(memberprototype5);
		this.connectableProperties1.MemberPrototypes.Add(memberprototype6);
		this.connectableProperties1.MemberPrototypes.Add(memberprototype7);
		// 
		// connectableProperties2
		// 
		this.connectableProperties2.DefaultValues = "";
		this.connectableProperties2.DisplayName = "Properties";
		this.connectableProperties2.ExceptionsHandled = false;
		this.connectableProperties2.InstanceTypeName = "System.Windows.Forms.TextBox";
		this.connectableProperties2.InstanceUniqueId = new OpenSpan.Design.ComponentIdentity("DesignForm-8D66C4BE51297C5\\TextBox-8D66C4C6CA996A9");
		memberprototype8.DefaultValue = null;
		memberprototype8.MemberName = "Text";
		memberprototype8.MemberType = System.Reflection.MemberTypes.Property;
		memberprototype8.Signature.ReturnType = null;
		memberprototype8.TypeName = "System.String";
		this.connectableProperties2.MemberPrototypes.Add(memberprototype8);
		// 
		// connectableProperties3
		// 
		this.connectableProperties3.DefaultValues = "";
		this.connectableProperties3.DisplayName = "Properties";
		this.connectableProperties3.ExceptionsHandled = false;
		this.connectableProperties3.InstanceTypeName = "System.Windows.Forms.TextBox";
		this.connectableProperties3.InstanceUniqueId = new OpenSpan.Design.ComponentIdentity("DesignForm-8D66C4BE51297C5\\TextBox-8D66C4C6FB73F63");
		memberprototype9.DefaultValue = null;
		memberprototype9.MemberName = "Text";
		memberprototype9.MemberType = System.Reflection.MemberTypes.Property;
		memberprototype9.Signature.ReturnType = null;
		memberprototype9.TypeName = "System.String";
		this.connectableProperties3.MemberPrototypes.Add(memberprototype9);
		// 
		// connectableProperties4
		// 
		this.connectableProperties4.DefaultValues = "";
		this.connectableProperties4.DisplayName = "Properties";
		this.connectableProperties4.ExceptionsHandled = false;
		this.connectableProperties4.InstanceTypeName = "System.Windows.Forms.TextBox";
		this.connectableProperties4.InstanceUniqueId = new OpenSpan.Design.ComponentIdentity("DesignForm-8D66C4BE51297C5\\TextBox-8D66C4C081BB5B1");
		memberprototype10.DefaultValue = null;
		memberprototype10.MemberName = "Text";
		memberprototype10.MemberType = System.Reflection.MemberTypes.Property;
		memberprototype10.Signature.ReturnType = null;
		memberprototype10.TypeName = "System.String";
		this.connectableProperties4.MemberPrototypes.Add(memberprototype10);
		// 
		// connectableProperties5
		// 
		this.connectableProperties5.DefaultValues = "";
		this.connectableProperties5.DisplayName = "Properties";
		this.connectableProperties5.ExceptionsHandled = false;
		this.connectableProperties5.InstanceTypeName = "System.Windows.Forms.TextBox";
		this.connectableProperties5.InstanceUniqueId = new OpenSpan.Design.ComponentIdentity("DesignForm-8D66C4BE51297C5\\TextBox-8D66C4C72B6CB56");
		memberprototype11.DefaultValue = null;
		memberprototype11.MemberName = "Text";
		memberprototype11.MemberType = System.Reflection.MemberTypes.Property;
		memberprototype11.Signature.ReturnType = null;
		memberprototype11.TypeName = "System.String";
		this.connectableProperties5.MemberPrototypes.Add(memberprototype11);
		// 
		// connectableProperties6
		// 
		this.connectableProperties6.DefaultValues = "";
		this.connectableProperties6.DisplayName = "Properties";
		this.connectableProperties6.ExceptionsHandled = false;
		this.connectableProperties6.InstanceTypeName = "System.Windows.Forms.TextBox";
		this.connectableProperties6.InstanceUniqueId = new OpenSpan.Design.ComponentIdentity("DesignForm-8D66C4BE51297C5\\TextBox-8D66C4E198DB838");
		memberprototype12.DefaultValue = null;
		memberprototype12.MemberName = "Text";
		memberprototype12.MemberType = System.Reflection.MemberTypes.Property;
		memberprototype12.Signature.ReturnType = null;
		memberprototype12.TypeName = "System.String";
		this.connectableProperties6.MemberPrototypes.Add(memberprototype12);
		// 
		// connectableProperties7
		// 
		this.connectableProperties7.DefaultValues = "";
		this.connectableProperties7.DisplayName = "Properties";
		this.connectableProperties7.ExceptionsHandled = false;
		this.connectableProperties7.InstanceTypeName = "System.Windows.Forms.ComboBox";
		this.connectableProperties7.InstanceUniqueId = new OpenSpan.Design.ComponentIdentity("DesignForm-8D66C4BE51297C5\\ComboBox-8D66C4C1810BB05");
		memberprototype13.DefaultValue = null;
		memberprototype13.MemberName = "Text";
		memberprototype13.MemberType = System.Reflection.MemberTypes.Property;
		memberprototype13.Signature.ReturnType = null;
		memberprototype13.TypeName = "System.String";
		this.connectableProperties7.MemberPrototypes.Add(memberprototype13);
		// 
		// Initialize CodeDom data
		// 
		this.CodeDomData = _resources_.GetString("_UIAutomation2_4_");
		// 
		// Add components
		// 
		this.mComponents = new System.Collections.Generic.List<System.ComponentModel.IComponent>(20);
		this.Components.Add(this.connectableEvent1);
		this.Components.Add(this.connectableProperties1);
		this.Components.Add(this.connectableProperties2);
		this.Components.Add(this.connectableProperties3);
		this.Components.Add(this.connectableProperties4);
		this.Components.Add(this.connectableProperties5);
		this.Components.Add(this.connectableProperties6);
		this.Components.Add(this.connectableProperties7);
	}
	
	private System.Collections.Generic.List<System.ComponentModel.IComponent> mComponents;
	
	public System.Collections.Generic.List<System.ComponentModel.IComponent> Components
	{
		get
		{
			return this.mComponents;
		}
	}
	
	/// <summary>
	/// Start design component.
	/// </summary>
	public override void Start()
	{
		base.Start();
	}
	
	/// <summary>
	/// Stop design component.
	/// </summary>
	public override void Stop()
	{
		base.Stop();
	}
	
	internal OpenSpan.Automation.ConnectableEvent Create_connectableEvent1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		System.ComponentModel.ComponentResourceManager _resources_ = new System.ComponentModel.ComponentResourceManager(typeof(UIAutomation2));
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Automation.ConnectableEvent connectableEvent1 = new OpenSpan.Automation.ConnectableEvent();
		this.SetId(connectableEvent1, new OpenSpan.Design.ComponentIdentity("ConnectableEvent-8D66CB7F4B356C5"));
		connectableEvent1.DisplayName = "null";
		connectableEvent1.ExceptionsHandled = false;
		connectableEvent1.InstanceTypeName = "OpenSpan.Interactions.Controls.Activity";
		connectableEvent1.InstanceUniqueId = new OpenSpan.Design.ComponentIdentity("GlobalContainer-8D66C51F4CAC0FC\\Activity-8D66CB221FFF252");
		OpenSpan.Automation.MemberPrototype memberprototype1 = new OpenSpan.Automation.MemberPrototype();
		memberprototype1.DefaultValue = null;
		memberprototype1.MemberName = "ActivityStarted";
		memberprototype1.MemberType = System.Reflection.MemberTypes.Event;
		memberprototype1.Signature.ReturnType = null;
		memberprototype1.TypeName = _resources_.GetString("_UIAutomation2_2_");
		connectableEvent1.MemberPrototypes.Add(memberprototype1);
		// 
		// Result
		// 
		return connectableEvent1;
	}
	
	internal OpenSpan.Automation.ConnectableProperties Create_connectableProperties1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		System.ComponentModel.ComponentResourceManager _resources_ = new System.ComponentModel.ComponentResourceManager(typeof(UIAutomation2));
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Automation.ConnectableProperties connectableProperties1 = new OpenSpan.Automation.ConnectableProperties();
		this.SetId(connectableProperties1, new OpenSpan.Design.ComponentIdentity("ConnectableProperties-8D66CB808684996"));
		connectableProperties1.DefaultValues = "";
		connectableProperties1.DisplayName = "Properties";
		OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicpropertyinfo1 = new OpenSpan.DynamicMembers.DynamicPropertyInfo();
		dynamicpropertyinfo1.IsSerializable = true;
		dynamicpropertyinfo1.NoInputConvesion = false;
		dynamicpropertyinfo1.Source = "";
		dynamicpropertyinfo1.ValidateConnectionCallback = null;
		dynamicpropertyinfo1.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicpropertyinfo1.CodeDomData = _resources_.GetString("_UIAutomation2_3_");
		connectableProperties1.DynamicMembers.Add(dynamicpropertyinfo1);
		connectableProperties1.ExceptionsHandled = false;
		connectableProperties1.InstanceTypeName = "OpenSpan.Interactions.Controls.InteractionManager";
		connectableProperties1.InstanceUniqueId = new OpenSpan.Design.ComponentIdentity("GlobalContainer-8D66C51F4CAC0FC\\InteractionManager-8D66C52238E76D0");
		OpenSpan.Automation.KeyInfo keyinfo1 = new OpenSpan.Automation.KeyInfo();
		keyinfo1.CloneContextId = new OpenSpan.Design.ComponentIdentity("GlobalContainer-8D66C51F4CAC0FC\\InteractionManager-8D66C52238E76D0");
		keyinfo1.KeyName = "Key";
		keyinfo1.KeyObjectTypeName = "OpenSpan.Interactions.Controls.InteractionKey";
		keyinfo1.KeyType = OpenSpan.Automation.CloneKeyType.Smart;
		keyinfo1.SetUpstream = false;
		keyinfo1.TokenizedText = null;
		connectableProperties1.KeyInfos.Add(keyinfo1);
		OpenSpan.Automation.MemberPrototype memberprototype1 = new OpenSpan.Automation.MemberPrototype();
		memberprototype1.DefaultValue = null;
		memberprototype1.MemberName = "ActNum";
		memberprototype1.MemberType = System.Reflection.MemberTypes.Property;
		memberprototype1.Signature.ReturnType = null;
		memberprototype1.TypeName = "System.Double";
		OpenSpan.Automation.MemberPrototype memberprototype2 = new OpenSpan.Automation.MemberPrototype();
		memberprototype2.DefaultValue = null;
		memberprototype2.MemberName = "Address";
		memberprototype2.MemberType = System.Reflection.MemberTypes.Property;
		memberprototype2.Signature.ReturnType = null;
		memberprototype2.TypeName = "System.String";
		OpenSpan.Automation.MemberPrototype memberprototype3 = new OpenSpan.Automation.MemberPrototype();
		memberprototype3.DefaultValue = null;
		memberprototype3.MemberName = "City";
		memberprototype3.MemberType = System.Reflection.MemberTypes.Property;
		memberprototype3.Signature.ReturnType = null;
		memberprototype3.TypeName = "System.String";
		OpenSpan.Automation.MemberPrototype memberprototype4 = new OpenSpan.Automation.MemberPrototype();
		memberprototype4.DefaultValue = null;
		memberprototype4.MemberName = "Name";
		memberprototype4.MemberType = System.Reflection.MemberTypes.Property;
		memberprototype4.Signature.ReturnType = null;
		memberprototype4.TypeName = "System.String";
		OpenSpan.Automation.MemberPrototype memberprototype5 = new OpenSpan.Automation.MemberPrototype();
		memberprototype5.DefaultValue = null;
		memberprototype5.MemberName = "State";
		memberprototype5.MemberType = System.Reflection.MemberTypes.Property;
		memberprototype5.Signature.ReturnType = null;
		memberprototype5.TypeName = "System.String";
		OpenSpan.Automation.MemberPrototype memberprototype6 = new OpenSpan.Automation.MemberPrototype();
		memberprototype6.DefaultValue = null;
		memberprototype6.MemberName = "Zipcode";
		memberprototype6.MemberType = System.Reflection.MemberTypes.Property;
		memberprototype6.Signature.ReturnType = null;
		memberprototype6.TypeName = "System.String";
		connectableProperties1.MemberPrototypes.Add(memberprototype1);
		connectableProperties1.MemberPrototypes.Add(memberprototype2);
		connectableProperties1.MemberPrototypes.Add(memberprototype3);
		connectableProperties1.MemberPrototypes.Add(memberprototype4);
		connectableProperties1.MemberPrototypes.Add(memberprototype5);
		connectableProperties1.MemberPrototypes.Add(memberprototype6);
		// 
		// Result
		// 
		return connectableProperties1;
	}
	
	internal OpenSpan.Automation.ConnectableProperties Create_connectableProperties2(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Automation.ConnectableProperties connectableProperties2 = new OpenSpan.Automation.ConnectableProperties();
		this.SetId(connectableProperties2, new OpenSpan.Design.ComponentIdentity("ConnectableProperties-8D66CB840EAD17D"));
		connectableProperties2.DefaultValues = "";
		connectableProperties2.DisplayName = "Properties";
		connectableProperties2.ExceptionsHandled = false;
		connectableProperties2.InstanceTypeName = "System.Windows.Forms.TextBox";
		connectableProperties2.InstanceUniqueId = new OpenSpan.Design.ComponentIdentity("DesignForm-8D66C4BE51297C5\\TextBox-8D66C4C6CA996A9");
		OpenSpan.Automation.MemberPrototype memberprototype1 = new OpenSpan.Automation.MemberPrototype();
		memberprototype1.DefaultValue = null;
		memberprototype1.MemberName = "Text";
		memberprototype1.MemberType = System.Reflection.MemberTypes.Property;
		memberprototype1.Signature.ReturnType = null;
		memberprototype1.TypeName = "System.String";
		connectableProperties2.MemberPrototypes.Add(memberprototype1);
		// 
		// Result
		// 
		return connectableProperties2;
	}
	
	internal OpenSpan.Automation.ConnectableProperties Create_connectableProperties3(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Automation.ConnectableProperties connectableProperties3 = new OpenSpan.Automation.ConnectableProperties();
		this.SetId(connectableProperties3, new OpenSpan.Design.ComponentIdentity("ConnectableProperties-8D66CB844A302CC"));
		connectableProperties3.DefaultValues = "";
		connectableProperties3.DisplayName = "Properties";
		connectableProperties3.ExceptionsHandled = false;
		connectableProperties3.InstanceTypeName = "System.Windows.Forms.TextBox";
		connectableProperties3.InstanceUniqueId = new OpenSpan.Design.ComponentIdentity("DesignForm-8D66C4BE51297C5\\TextBox-8D66C4C6FB73F63");
		OpenSpan.Automation.MemberPrototype memberprototype1 = new OpenSpan.Automation.MemberPrototype();
		memberprototype1.DefaultValue = null;
		memberprototype1.MemberName = "Text";
		memberprototype1.MemberType = System.Reflection.MemberTypes.Property;
		memberprototype1.Signature.ReturnType = null;
		memberprototype1.TypeName = "System.String";
		connectableProperties3.MemberPrototypes.Add(memberprototype1);
		// 
		// Result
		// 
		return connectableProperties3;
	}
	
	internal OpenSpan.Automation.ConnectableProperties Create_connectableProperties4(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Automation.ConnectableProperties connectableProperties4 = new OpenSpan.Automation.ConnectableProperties();
		this.SetId(connectableProperties4, new OpenSpan.Design.ComponentIdentity("ConnectableProperties-8D66CB8471C7CA5"));
		connectableProperties4.DefaultValues = "";
		connectableProperties4.DisplayName = "Properties";
		connectableProperties4.ExceptionsHandled = false;
		connectableProperties4.InstanceTypeName = "System.Windows.Forms.TextBox";
		connectableProperties4.InstanceUniqueId = new OpenSpan.Design.ComponentIdentity("DesignForm-8D66C4BE51297C5\\TextBox-8D66C4C081BB5B1");
		OpenSpan.Automation.MemberPrototype memberprototype1 = new OpenSpan.Automation.MemberPrototype();
		memberprototype1.DefaultValue = null;
		memberprototype1.MemberName = "Text";
		memberprototype1.MemberType = System.Reflection.MemberTypes.Property;
		memberprototype1.Signature.ReturnType = null;
		memberprototype1.TypeName = "System.String";
		connectableProperties4.MemberPrototypes.Add(memberprototype1);
		// 
		// Result
		// 
		return connectableProperties4;
	}
	
	internal OpenSpan.Automation.ConnectableProperties Create_connectableProperties5(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Automation.ConnectableProperties connectableProperties5 = new OpenSpan.Automation.ConnectableProperties();
		this.SetId(connectableProperties5, new OpenSpan.Design.ComponentIdentity("ConnectableProperties-8D66CB849716F43"));
		connectableProperties5.DefaultValues = "";
		connectableProperties5.DisplayName = "Properties";
		connectableProperties5.ExceptionsHandled = false;
		connectableProperties5.InstanceTypeName = "System.Windows.Forms.TextBox";
		connectableProperties5.InstanceUniqueId = new OpenSpan.Design.ComponentIdentity("DesignForm-8D66C4BE51297C5\\TextBox-8D66C4C72B6CB56");
		OpenSpan.Automation.MemberPrototype memberprototype1 = new OpenSpan.Automation.MemberPrototype();
		memberprototype1.DefaultValue = null;
		memberprototype1.MemberName = "Text";
		memberprototype1.MemberType = System.Reflection.MemberTypes.Property;
		memberprototype1.Signature.ReturnType = null;
		memberprototype1.TypeName = "System.String";
		connectableProperties5.MemberPrototypes.Add(memberprototype1);
		// 
		// Result
		// 
		return connectableProperties5;
	}
	
	internal OpenSpan.Automation.ConnectableProperties Create_connectableProperties6(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Automation.ConnectableProperties connectableProperties6 = new OpenSpan.Automation.ConnectableProperties();
		this.SetId(connectableProperties6, new OpenSpan.Design.ComponentIdentity("ConnectableProperties-8D66CB84C120342"));
		connectableProperties6.DefaultValues = "";
		connectableProperties6.DisplayName = "Properties";
		connectableProperties6.ExceptionsHandled = false;
		connectableProperties6.InstanceTypeName = "System.Windows.Forms.TextBox";
		connectableProperties6.InstanceUniqueId = new OpenSpan.Design.ComponentIdentity("DesignForm-8D66C4BE51297C5\\TextBox-8D66C4E198DB838");
		OpenSpan.Automation.MemberPrototype memberprototype1 = new OpenSpan.Automation.MemberPrototype();
		memberprototype1.DefaultValue = null;
		memberprototype1.MemberName = "Text";
		memberprototype1.MemberType = System.Reflection.MemberTypes.Property;
		memberprototype1.Signature.ReturnType = null;
		memberprototype1.TypeName = "System.String";
		connectableProperties6.MemberPrototypes.Add(memberprototype1);
		// 
		// Result
		// 
		return connectableProperties6;
	}
	
	internal OpenSpan.Automation.ConnectableProperties Create_connectableProperties7(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Automation.ConnectableProperties connectableProperties7 = new OpenSpan.Automation.ConnectableProperties();
		this.SetId(connectableProperties7, new OpenSpan.Design.ComponentIdentity("ConnectableProperties-8D66CBB07BB1FE8"));
		connectableProperties7.DefaultValues = "";
		connectableProperties7.DisplayName = "Properties";
		connectableProperties7.ExceptionsHandled = false;
		connectableProperties7.InstanceTypeName = "System.Windows.Forms.ComboBox";
		connectableProperties7.InstanceUniqueId = new OpenSpan.Design.ComponentIdentity("DesignForm-8D66C4BE51297C5\\ComboBox-8D66C4C1810BB05");
		OpenSpan.Automation.MemberPrototype memberprototype1 = new OpenSpan.Automation.MemberPrototype();
		memberprototype1.DefaultValue = null;
		memberprototype1.MemberName = "Text";
		memberprototype1.MemberType = System.Reflection.MemberTypes.Property;
		memberprototype1.Signature.ReturnType = null;
		memberprototype1.TypeName = "System.String";
		connectableProperties7.MemberPrototypes.Add(memberprototype1);
		// 
		// Result
		// 
		return connectableProperties7;
	}
}

}

