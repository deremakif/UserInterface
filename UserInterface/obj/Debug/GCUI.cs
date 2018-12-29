using System;

namespace UserInterface
{
/// <summary>
/// OpenSpan design component.
/// </summary>
// GlobalContainer-8D66C51F4CAC0FC
[OpenSpan.Design.ComponentIdentityAttribute("GlobalContainer-8D66C51F4CAC0FC")]
[System.ComponentModel.ToolboxItemAttribute(false)]
public sealed class GCUI : OpenSpan.Automation.GlobalContainer
{
	
	[OpenSpan.Design.ComponentIdentityAttribute("GlobalContainer-8D66C51F4CAC0FC\\InteractionManager-8D66C52238E76D0")]
	public OpenSpan.Interactions.Controls.InteractionManager ınteractionManager1;
	
	[OpenSpan.Design.ComponentIdentityAttribute("GlobalContainer-8D66C51F4CAC0FC\\Activity-8D66CB221FFF252")]
	public OpenSpan.Interactions.Controls.Activity UpdateInfo;
	
	[OpenSpan.Design.ComponentIdentityAttribute("GlobalContainer-8D66C51F4CAC0FC\\Activity-8D66CB2C8BC3813")]
	public OpenSpan.Interactions.Controls.Activity ActivateWindow;
	
	public GCUI()
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Setup field members
		// 
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GCUI));
		OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicpropertyinfo1 = new OpenSpan.DynamicMembers.DynamicPropertyInfo();
		OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicpropertyinfo2 = new OpenSpan.DynamicMembers.DynamicPropertyInfo();
		OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicpropertyinfo3 = new OpenSpan.DynamicMembers.DynamicPropertyInfo();
		OpenSpan.DynamicMembers.DynamicEventInfo dynamiceventinfo1 = new OpenSpan.DynamicMembers.DynamicEventInfo();
		OpenSpan.DynamicMembers.DynamicEventInfo dynamiceventinfo2 = new OpenSpan.DynamicMembers.DynamicEventInfo();
		OpenSpan.DynamicMembers.DynamicEventInfo dynamiceventinfo3 = new OpenSpan.DynamicMembers.DynamicEventInfo();
		OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicpropertyinfo4 = new OpenSpan.DynamicMembers.DynamicPropertyInfo();
		OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicpropertyinfo5 = new OpenSpan.DynamicMembers.DynamicPropertyInfo();
		OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicpropertyinfo6 = new OpenSpan.DynamicMembers.DynamicPropertyInfo();
		OpenSpan.DynamicMembers.DynamicEventInfo dynamiceventinfo4 = new OpenSpan.DynamicMembers.DynamicEventInfo();
		OpenSpan.DynamicMembers.DynamicEventInfo dynamiceventinfo5 = new OpenSpan.DynamicMembers.DynamicEventInfo();
		OpenSpan.DynamicMembers.DynamicEventInfo dynamiceventinfo6 = new OpenSpan.DynamicMembers.DynamicEventInfo();
		OpenSpan.DynamicMembers.DynamicMethodInfo dynamicmethodinfo1 = new OpenSpan.DynamicMembers.DynamicMethodInfo();
		OpenSpan.DynamicMembers.DynamicMethodInfo dynamicmethodinfo2 = new OpenSpan.DynamicMembers.DynamicMethodInfo();
		OpenSpan.DynamicMembers.DynamicMethodInfo dynamicmethodinfo3 = new OpenSpan.DynamicMembers.DynamicMethodInfo();
		OpenSpan.DynamicMembers.DynamicMethodInfo dynamicmethodinfo4 = new OpenSpan.DynamicMembers.DynamicMethodInfo();
		OpenSpan.DynamicMembers.DynamicMethodInfo dynamicmethodinfo5 = new OpenSpan.DynamicMembers.DynamicMethodInfo();
		OpenSpan.DynamicMembers.DynamicMethodInfo dynamicmethodinfo6 = new OpenSpan.DynamicMembers.DynamicMethodInfo();
		OpenSpan.DynamicMembers.DynamicMethodInfo dynamicmethodinfo7 = new OpenSpan.DynamicMembers.DynamicMethodInfo();
		OpenSpan.DynamicMembers.DynamicMethodInfo dynamicmethodinfo8 = new OpenSpan.DynamicMembers.DynamicMethodInfo();
		OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicpropertyinfo7 = new OpenSpan.DynamicMembers.DynamicPropertyInfo();
		OpenSpan.DynamicMembers.DynamicMethodInfo dynamicmethodinfo9 = new OpenSpan.DynamicMembers.DynamicMethodInfo();
		OpenSpan.DynamicMembers.DynamicMethodInfo dynamicmethodinfo10 = new OpenSpan.DynamicMembers.DynamicMethodInfo();
		OpenSpan.DynamicMembers.DynamicMethodInfo dynamicmethodinfo11 = new OpenSpan.DynamicMembers.DynamicMethodInfo();
		OpenSpan.DynamicMembers.DynamicMethodInfo dynamicmethodinfo12 = new OpenSpan.DynamicMembers.DynamicMethodInfo();
		OpenSpan.DynamicMembers.DynamicMethodInfo dynamicmethodinfo13 = new OpenSpan.DynamicMembers.DynamicMethodInfo();
		OpenSpan.DynamicMembers.DynamicMethodInfo dynamicmethodinfo14 = new OpenSpan.DynamicMembers.DynamicMethodInfo();
		OpenSpan.DynamicMembers.DynamicMethodInfo dynamicmethodinfo15 = new OpenSpan.DynamicMembers.DynamicMethodInfo();
		OpenSpan.DynamicMembers.DynamicMethodInfo dynamicmethodinfo16 = new OpenSpan.DynamicMembers.DynamicMethodInfo();
		this.ınteractionManager1 = new OpenSpan.Interactions.Controls.InteractionManager();
		this.UpdateInfo = new OpenSpan.Interactions.Controls.Activity();
		this.ActivateWindow = new OpenSpan.Interactions.Controls.Activity();
		// 
		// Initialize design component
		// 
		this.Initialize();
		// 
		// Set design component Id
		// 
		this.Id = new OpenSpan.Design.ComponentIdentity("GlobalContainer-8D66C51F4CAC0FC");
		// 
		// Set component Ids
		// 
		this.SetId(this.ınteractionManager1, new OpenSpan.Design.ComponentIdentity("InteractionManager-8D66C52238E76D0"));
		this.SetId(this.UpdateInfo, new OpenSpan.Design.ComponentIdentity("Activity-8D66CB221FFF252"));
		this.SetId(this.ActivateWindow, new OpenSpan.Design.ComponentIdentity("Activity-8D66CB2C8BC3813"));
		// 
		// GCUI
		// 
		ComponentInfo.CodeDomData = resources.GetString("_GCUI_1_");
		this.IsStartStoppable = false;
		this.Name = "GCUI";
		// 
		// ınteractionManager1
		// 
		dynamicpropertyinfo1.IsSerializable = true;
		dynamicpropertyinfo1.NoInputConvesion = false;
		dynamicpropertyinfo1.Source = "";
		dynamicpropertyinfo1.ValidateConnectionCallback = null;
		dynamicpropertyinfo1.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicpropertyinfo1.CodeDomData = resources.GetString("_GCUI_2_");
		dynamicpropertyinfo2.IsSerializable = true;
		dynamicpropertyinfo2.NoInputConvesion = false;
		dynamicpropertyinfo2.Source = "";
		dynamicpropertyinfo2.ValidateConnectionCallback = null;
		dynamicpropertyinfo2.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicpropertyinfo2.CodeDomData = resources.GetString("_GCUI_3_");
		dynamicpropertyinfo3.IsSerializable = true;
		dynamicpropertyinfo3.NoInputConvesion = false;
		dynamicpropertyinfo3.Source = "";
		dynamicpropertyinfo3.ValidateConnectionCallback = null;
		dynamicpropertyinfo3.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicpropertyinfo3.CodeDomData = resources.GetString("_GCUI_4_");
		dynamiceventinfo1.Source = "";
		dynamiceventinfo1.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamiceventinfo1.CodeDomData = resources.GetString("_GCUI_5_");
		dynamiceventinfo2.Source = "";
		dynamiceventinfo2.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamiceventinfo2.CodeDomData = resources.GetString("_GCUI_6_");
		dynamiceventinfo3.Source = "";
		dynamiceventinfo3.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamiceventinfo3.CodeDomData = resources.GetString("_GCUI_7_");
		dynamicpropertyinfo4.IsSerializable = true;
		dynamicpropertyinfo4.NoInputConvesion = false;
		dynamicpropertyinfo4.Source = "";
		dynamicpropertyinfo4.ValidateConnectionCallback = null;
		dynamicpropertyinfo4.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicpropertyinfo4.CodeDomData = resources.GetString("_GCUI_8_");
		dynamicpropertyinfo5.IsSerializable = true;
		dynamicpropertyinfo5.NoInputConvesion = false;
		dynamicpropertyinfo5.Source = "";
		dynamicpropertyinfo5.ValidateConnectionCallback = null;
		dynamicpropertyinfo5.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicpropertyinfo5.CodeDomData = resources.GetString("_GCUI_9_");
		dynamicpropertyinfo6.IsSerializable = true;
		dynamicpropertyinfo6.NoInputConvesion = false;
		dynamicpropertyinfo6.Source = "";
		dynamicpropertyinfo6.ValidateConnectionCallback = null;
		dynamicpropertyinfo6.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicpropertyinfo6.CodeDomData = resources.GetString("_GCUI_10_");
		dynamiceventinfo4.Source = "";
		dynamiceventinfo4.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamiceventinfo4.CodeDomData = resources.GetString("_GCUI_11_");
		dynamiceventinfo5.Source = "";
		dynamiceventinfo5.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamiceventinfo5.CodeDomData = resources.GetString("_GCUI_12_");
		dynamiceventinfo6.Source = "";
		dynamiceventinfo6.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamiceventinfo6.CodeDomData = resources.GetString("_GCUI_13_");
		this.ınteractionManager1.DynamicMembers.Add(dynamicpropertyinfo1);
		this.ınteractionManager1.DynamicMembers.Add(dynamicpropertyinfo2);
		this.ınteractionManager1.DynamicMembers.Add(dynamicpropertyinfo3);
		this.ınteractionManager1.DynamicMembers.Add(dynamiceventinfo1);
		this.ınteractionManager1.DynamicMembers.Add(dynamiceventinfo2);
		this.ınteractionManager1.DynamicMembers.Add(dynamiceventinfo3);
		this.ınteractionManager1.DynamicMembers.Add(dynamicpropertyinfo4);
		this.ınteractionManager1.DynamicMembers.Add(dynamicpropertyinfo5);
		this.ınteractionManager1.DynamicMembers.Add(dynamicpropertyinfo6);
		this.ınteractionManager1.DynamicMembers.Add(dynamiceventinfo4);
		this.ınteractionManager1.DynamicMembers.Add(dynamiceventinfo5);
		this.ınteractionManager1.DynamicMembers.Add(dynamiceventinfo6);
		this.ınteractionManager1.Prototype = null;
		this.ınteractionManager1.TableSchema = resources.GetString("ınteractionManager1.TableSchema");
		this.ınteractionManager1.UseKeys = true;
		// 
		// UpdateInfo
		// 
		this.UpdateInfo.ActivityName = "UpdateDisplay";
		dynamicmethodinfo1.Source = "";
		dynamicmethodinfo1.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicmethodinfo1.CodeDomData = resources.GetString("_GCUI_14_");
		dynamicmethodinfo2.Source = "";
		dynamicmethodinfo2.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicmethodinfo2.CodeDomData = resources.GetString("_GCUI_15_");
		dynamicmethodinfo3.Source = "";
		dynamicmethodinfo3.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicmethodinfo3.CodeDomData = resources.GetString("_GCUI_16_");
		dynamicmethodinfo4.Source = "";
		dynamicmethodinfo4.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicmethodinfo4.CodeDomData = resources.GetString("_GCUI_17_");
		dynamicmethodinfo5.Source = "";
		dynamicmethodinfo5.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicmethodinfo5.CodeDomData = resources.GetString("_GCUI_18_");
		dynamicmethodinfo6.Source = "";
		dynamicmethodinfo6.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicmethodinfo6.CodeDomData = resources.GetString("_GCUI_19_");
		dynamicmethodinfo7.Source = "";
		dynamicmethodinfo7.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicmethodinfo7.CodeDomData = resources.GetString("_GCUI_20_");
		dynamicmethodinfo8.Source = "";
		dynamicmethodinfo8.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicmethodinfo8.CodeDomData = resources.GetString("_GCUI_21_");
		this.UpdateInfo.DynamicMembers.Add(dynamicmethodinfo1);
		this.UpdateInfo.DynamicMembers.Add(dynamicmethodinfo2);
		this.UpdateInfo.DynamicMembers.Add(dynamicmethodinfo3);
		this.UpdateInfo.DynamicMembers.Add(dynamicmethodinfo4);
		this.UpdateInfo.DynamicMembers.Add(dynamicmethodinfo5);
		this.UpdateInfo.DynamicMembers.Add(dynamicmethodinfo6);
		this.UpdateInfo.DynamicMembers.Add(dynamicmethodinfo7);
		this.UpdateInfo.DynamicMembers.Add(dynamicmethodinfo8);
		// 
		// ActivateWindow
		// 
		this.ActivateWindow.ActivityName = "ActiveMDIWindow";
		dynamicpropertyinfo7.IsSerializable = true;
		dynamicpropertyinfo7.NoInputConvesion = false;
		dynamicpropertyinfo7.Source = "";
		dynamicpropertyinfo7.ValidateConnectionCallback = null;
		dynamicpropertyinfo7.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicpropertyinfo7.CodeDomData = resources.GetString("_GCUI_22_");
		dynamicmethodinfo9.Source = "";
		dynamicmethodinfo9.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicmethodinfo9.CodeDomData = resources.GetString("_GCUI_23_");
		dynamicmethodinfo10.Source = "";
		dynamicmethodinfo10.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicmethodinfo10.CodeDomData = resources.GetString("_GCUI_24_");
		dynamicmethodinfo11.Source = "";
		dynamicmethodinfo11.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicmethodinfo11.CodeDomData = resources.GetString("_GCUI_25_");
		dynamicmethodinfo12.Source = "";
		dynamicmethodinfo12.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicmethodinfo12.CodeDomData = resources.GetString("_GCUI_26_");
		dynamicmethodinfo13.Source = "";
		dynamicmethodinfo13.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicmethodinfo13.CodeDomData = resources.GetString("_GCUI_27_");
		dynamicmethodinfo14.Source = "";
		dynamicmethodinfo14.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicmethodinfo14.CodeDomData = resources.GetString("_GCUI_28_");
		dynamicmethodinfo15.Source = "";
		dynamicmethodinfo15.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicmethodinfo15.CodeDomData = resources.GetString("_GCUI_29_");
		dynamicmethodinfo16.Source = "";
		dynamicmethodinfo16.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicmethodinfo16.CodeDomData = resources.GetString("_GCUI_30_");
		this.ActivateWindow.DynamicMembers.Add(dynamicpropertyinfo7);
		this.ActivateWindow.DynamicMembers.Add(dynamicmethodinfo9);
		this.ActivateWindow.DynamicMembers.Add(dynamicmethodinfo10);
		this.ActivateWindow.DynamicMembers.Add(dynamicmethodinfo11);
		this.ActivateWindow.DynamicMembers.Add(dynamicmethodinfo12);
		this.ActivateWindow.DynamicMembers.Add(dynamicmethodinfo13);
		this.ActivateWindow.DynamicMembers.Add(dynamicmethodinfo14);
		this.ActivateWindow.DynamicMembers.Add(dynamicmethodinfo15);
		this.ActivateWindow.DynamicMembers.Add(dynamicmethodinfo16);
		// 
		// Add components
		// 
		this.mComponents = new System.Collections.Generic.List<System.ComponentModel.IComponent>(20);
		this.Components.Add(this.ınteractionManager1);
		this.Components.Add(this.UpdateInfo);
		this.Components.Add(this.ActivateWindow);
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
	
	internal OpenSpan.Interactions.Controls.InteractionManager Create_ınteractionManager1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GCUI));
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Interactions.Controls.InteractionManager ınteractionManager1 = new OpenSpan.Interactions.Controls.InteractionManager();
		this.SetId(ınteractionManager1, new OpenSpan.Design.ComponentIdentity("InteractionManager-8D66C52238E76D0"));
		OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicpropertyinfo1 = new OpenSpan.DynamicMembers.DynamicPropertyInfo();
		dynamicpropertyinfo1.IsSerializable = true;
		dynamicpropertyinfo1.NoInputConvesion = false;
		dynamicpropertyinfo1.Source = "";
		dynamicpropertyinfo1.ValidateConnectionCallback = null;
		dynamicpropertyinfo1.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicpropertyinfo1.CodeDomData = resources.GetString("_GCUI_2_");
		OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicpropertyinfo2 = new OpenSpan.DynamicMembers.DynamicPropertyInfo();
		dynamicpropertyinfo2.IsSerializable = true;
		dynamicpropertyinfo2.NoInputConvesion = false;
		dynamicpropertyinfo2.Source = "";
		dynamicpropertyinfo2.ValidateConnectionCallback = null;
		dynamicpropertyinfo2.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicpropertyinfo2.CodeDomData = resources.GetString("_GCUI_3_");
		OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicpropertyinfo3 = new OpenSpan.DynamicMembers.DynamicPropertyInfo();
		dynamicpropertyinfo3.IsSerializable = true;
		dynamicpropertyinfo3.NoInputConvesion = false;
		dynamicpropertyinfo3.Source = "";
		dynamicpropertyinfo3.ValidateConnectionCallback = null;
		dynamicpropertyinfo3.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicpropertyinfo3.CodeDomData = resources.GetString("_GCUI_4_");
		OpenSpan.DynamicMembers.DynamicEventInfo dynamiceventinfo1 = new OpenSpan.DynamicMembers.DynamicEventInfo();
		dynamiceventinfo1.Source = "";
		dynamiceventinfo1.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamiceventinfo1.CodeDomData = resources.GetString("_GCUI_5_");
		OpenSpan.DynamicMembers.DynamicEventInfo dynamiceventinfo2 = new OpenSpan.DynamicMembers.DynamicEventInfo();
		dynamiceventinfo2.Source = "";
		dynamiceventinfo2.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamiceventinfo2.CodeDomData = resources.GetString("_GCUI_6_");
		OpenSpan.DynamicMembers.DynamicEventInfo dynamiceventinfo3 = new OpenSpan.DynamicMembers.DynamicEventInfo();
		dynamiceventinfo3.Source = "";
		dynamiceventinfo3.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamiceventinfo3.CodeDomData = resources.GetString("_GCUI_7_");
		OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicpropertyinfo4 = new OpenSpan.DynamicMembers.DynamicPropertyInfo();
		dynamicpropertyinfo4.IsSerializable = true;
		dynamicpropertyinfo4.NoInputConvesion = false;
		dynamicpropertyinfo4.Source = "";
		dynamicpropertyinfo4.ValidateConnectionCallback = null;
		dynamicpropertyinfo4.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicpropertyinfo4.CodeDomData = resources.GetString("_GCUI_8_");
		OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicpropertyinfo5 = new OpenSpan.DynamicMembers.DynamicPropertyInfo();
		dynamicpropertyinfo5.IsSerializable = true;
		dynamicpropertyinfo5.NoInputConvesion = false;
		dynamicpropertyinfo5.Source = "";
		dynamicpropertyinfo5.ValidateConnectionCallback = null;
		dynamicpropertyinfo5.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicpropertyinfo5.CodeDomData = resources.GetString("_GCUI_9_");
		OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicpropertyinfo6 = new OpenSpan.DynamicMembers.DynamicPropertyInfo();
		dynamicpropertyinfo6.IsSerializable = true;
		dynamicpropertyinfo6.NoInputConvesion = false;
		dynamicpropertyinfo6.Source = "";
		dynamicpropertyinfo6.ValidateConnectionCallback = null;
		dynamicpropertyinfo6.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicpropertyinfo6.CodeDomData = resources.GetString("_GCUI_10_");
		OpenSpan.DynamicMembers.DynamicEventInfo dynamiceventinfo4 = new OpenSpan.DynamicMembers.DynamicEventInfo();
		dynamiceventinfo4.Source = "";
		dynamiceventinfo4.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamiceventinfo4.CodeDomData = resources.GetString("_GCUI_11_");
		OpenSpan.DynamicMembers.DynamicEventInfo dynamiceventinfo5 = new OpenSpan.DynamicMembers.DynamicEventInfo();
		dynamiceventinfo5.Source = "";
		dynamiceventinfo5.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamiceventinfo5.CodeDomData = resources.GetString("_GCUI_12_");
		OpenSpan.DynamicMembers.DynamicEventInfo dynamiceventinfo6 = new OpenSpan.DynamicMembers.DynamicEventInfo();
		dynamiceventinfo6.Source = "";
		dynamiceventinfo6.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamiceventinfo6.CodeDomData = resources.GetString("_GCUI_13_");
		ınteractionManager1.DynamicMembers.Add(dynamicpropertyinfo1);
		ınteractionManager1.DynamicMembers.Add(dynamicpropertyinfo2);
		ınteractionManager1.DynamicMembers.Add(dynamicpropertyinfo3);
		ınteractionManager1.DynamicMembers.Add(dynamiceventinfo1);
		ınteractionManager1.DynamicMembers.Add(dynamiceventinfo2);
		ınteractionManager1.DynamicMembers.Add(dynamiceventinfo3);
		ınteractionManager1.DynamicMembers.Add(dynamicpropertyinfo4);
		ınteractionManager1.DynamicMembers.Add(dynamicpropertyinfo5);
		ınteractionManager1.DynamicMembers.Add(dynamicpropertyinfo6);
		ınteractionManager1.DynamicMembers.Add(dynamiceventinfo4);
		ınteractionManager1.DynamicMembers.Add(dynamiceventinfo5);
		ınteractionManager1.DynamicMembers.Add(dynamiceventinfo6);
		ınteractionManager1.Prototype = null;
		ınteractionManager1.TableSchema = resources.GetString("ınteractionManager1.TableSchema");
		ınteractionManager1.UseKeys = true;
		// 
		// Result
		// 
		return ınteractionManager1;
	}
	
	internal OpenSpan.Interactions.Controls.Activity Create_UpdateInfo(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		System.ComponentModel.ComponentResourceManager _resources_ = new System.ComponentModel.ComponentResourceManager(typeof(GCUI));
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Interactions.Controls.Activity UpdateInfo = new OpenSpan.Interactions.Controls.Activity();
		this.SetId(UpdateInfo, new OpenSpan.Design.ComponentIdentity("Activity-8D66CB221FFF252"));
		UpdateInfo.ActivityName = "UpdateDisplay";
		OpenSpan.DynamicMembers.DynamicMethodInfo dynamicmethodinfo1 = new OpenSpan.DynamicMembers.DynamicMethodInfo();
		dynamicmethodinfo1.Source = "";
		dynamicmethodinfo1.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicmethodinfo1.CodeDomData = _resources_.GetString("_GCUI_14_");
		OpenSpan.DynamicMembers.DynamicMethodInfo dynamicmethodinfo2 = new OpenSpan.DynamicMembers.DynamicMethodInfo();
		dynamicmethodinfo2.Source = "";
		dynamicmethodinfo2.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicmethodinfo2.CodeDomData = _resources_.GetString("_GCUI_15_");
		OpenSpan.DynamicMembers.DynamicMethodInfo dynamicmethodinfo3 = new OpenSpan.DynamicMembers.DynamicMethodInfo();
		dynamicmethodinfo3.Source = "";
		dynamicmethodinfo3.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicmethodinfo3.CodeDomData = _resources_.GetString("_GCUI_16_");
		OpenSpan.DynamicMembers.DynamicMethodInfo dynamicmethodinfo4 = new OpenSpan.DynamicMembers.DynamicMethodInfo();
		dynamicmethodinfo4.Source = "";
		dynamicmethodinfo4.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicmethodinfo4.CodeDomData = _resources_.GetString("_GCUI_17_");
		OpenSpan.DynamicMembers.DynamicMethodInfo dynamicmethodinfo5 = new OpenSpan.DynamicMembers.DynamicMethodInfo();
		dynamicmethodinfo5.Source = "";
		dynamicmethodinfo5.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicmethodinfo5.CodeDomData = _resources_.GetString("_GCUI_18_");
		OpenSpan.DynamicMembers.DynamicMethodInfo dynamicmethodinfo6 = new OpenSpan.DynamicMembers.DynamicMethodInfo();
		dynamicmethodinfo6.Source = "";
		dynamicmethodinfo6.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicmethodinfo6.CodeDomData = _resources_.GetString("_GCUI_19_");
		OpenSpan.DynamicMembers.DynamicMethodInfo dynamicmethodinfo7 = new OpenSpan.DynamicMembers.DynamicMethodInfo();
		dynamicmethodinfo7.Source = "";
		dynamicmethodinfo7.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicmethodinfo7.CodeDomData = _resources_.GetString("_GCUI_20_");
		OpenSpan.DynamicMembers.DynamicMethodInfo dynamicmethodinfo8 = new OpenSpan.DynamicMembers.DynamicMethodInfo();
		dynamicmethodinfo8.Source = "";
		dynamicmethodinfo8.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicmethodinfo8.CodeDomData = _resources_.GetString("_GCUI_21_");
		UpdateInfo.DynamicMembers.Add(dynamicmethodinfo1);
		UpdateInfo.DynamicMembers.Add(dynamicmethodinfo2);
		UpdateInfo.DynamicMembers.Add(dynamicmethodinfo3);
		UpdateInfo.DynamicMembers.Add(dynamicmethodinfo4);
		UpdateInfo.DynamicMembers.Add(dynamicmethodinfo5);
		UpdateInfo.DynamicMembers.Add(dynamicmethodinfo6);
		UpdateInfo.DynamicMembers.Add(dynamicmethodinfo7);
		UpdateInfo.DynamicMembers.Add(dynamicmethodinfo8);
		// 
		// Result
		// 
		return UpdateInfo;
	}
	
	internal OpenSpan.Interactions.Controls.Activity Create_ActivateWindow(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		System.ComponentModel.ComponentResourceManager _resources_ = new System.ComponentModel.ComponentResourceManager(typeof(GCUI));
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Interactions.Controls.Activity ActivateWindow = new OpenSpan.Interactions.Controls.Activity();
		this.SetId(ActivateWindow, new OpenSpan.Design.ComponentIdentity("Activity-8D66CB2C8BC3813"));
		ActivateWindow.ActivityName = "ActiveMDIWindow";
		OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicpropertyinfo1 = new OpenSpan.DynamicMembers.DynamicPropertyInfo();
		dynamicpropertyinfo1.IsSerializable = true;
		dynamicpropertyinfo1.NoInputConvesion = false;
		dynamicpropertyinfo1.Source = "";
		dynamicpropertyinfo1.ValidateConnectionCallback = null;
		dynamicpropertyinfo1.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicpropertyinfo1.CodeDomData = _resources_.GetString("_GCUI_22_");
		OpenSpan.DynamicMembers.DynamicMethodInfo dynamicmethodinfo1 = new OpenSpan.DynamicMembers.DynamicMethodInfo();
		dynamicmethodinfo1.Source = "";
		dynamicmethodinfo1.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicmethodinfo1.CodeDomData = _resources_.GetString("_GCUI_23_");
		OpenSpan.DynamicMembers.DynamicMethodInfo dynamicmethodinfo2 = new OpenSpan.DynamicMembers.DynamicMethodInfo();
		dynamicmethodinfo2.Source = "";
		dynamicmethodinfo2.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicmethodinfo2.CodeDomData = _resources_.GetString("_GCUI_24_");
		OpenSpan.DynamicMembers.DynamicMethodInfo dynamicmethodinfo3 = new OpenSpan.DynamicMembers.DynamicMethodInfo();
		dynamicmethodinfo3.Source = "";
		dynamicmethodinfo3.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicmethodinfo3.CodeDomData = _resources_.GetString("_GCUI_25_");
		OpenSpan.DynamicMembers.DynamicMethodInfo dynamicmethodinfo4 = new OpenSpan.DynamicMembers.DynamicMethodInfo();
		dynamicmethodinfo4.Source = "";
		dynamicmethodinfo4.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicmethodinfo4.CodeDomData = _resources_.GetString("_GCUI_26_");
		OpenSpan.DynamicMembers.DynamicMethodInfo dynamicmethodinfo5 = new OpenSpan.DynamicMembers.DynamicMethodInfo();
		dynamicmethodinfo5.Source = "";
		dynamicmethodinfo5.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicmethodinfo5.CodeDomData = _resources_.GetString("_GCUI_27_");
		OpenSpan.DynamicMembers.DynamicMethodInfo dynamicmethodinfo6 = new OpenSpan.DynamicMembers.DynamicMethodInfo();
		dynamicmethodinfo6.Source = "";
		dynamicmethodinfo6.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicmethodinfo6.CodeDomData = _resources_.GetString("_GCUI_28_");
		OpenSpan.DynamicMembers.DynamicMethodInfo dynamicmethodinfo7 = new OpenSpan.DynamicMembers.DynamicMethodInfo();
		dynamicmethodinfo7.Source = "";
		dynamicmethodinfo7.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicmethodinfo7.CodeDomData = _resources_.GetString("_GCUI_29_");
		OpenSpan.DynamicMembers.DynamicMethodInfo dynamicmethodinfo8 = new OpenSpan.DynamicMembers.DynamicMethodInfo();
		dynamicmethodinfo8.Source = "";
		dynamicmethodinfo8.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicmethodinfo8.CodeDomData = _resources_.GetString("_GCUI_30_");
		ActivateWindow.DynamicMembers.Add(dynamicpropertyinfo1);
		ActivateWindow.DynamicMembers.Add(dynamicmethodinfo1);
		ActivateWindow.DynamicMembers.Add(dynamicmethodinfo2);
		ActivateWindow.DynamicMembers.Add(dynamicmethodinfo3);
		ActivateWindow.DynamicMembers.Add(dynamicmethodinfo4);
		ActivateWindow.DynamicMembers.Add(dynamicmethodinfo5);
		ActivateWindow.DynamicMembers.Add(dynamicmethodinfo6);
		ActivateWindow.DynamicMembers.Add(dynamicmethodinfo7);
		ActivateWindow.DynamicMembers.Add(dynamicmethodinfo8);
		// 
		// Result
		// 
		return ActivateWindow;
	}
}

}

