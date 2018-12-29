using UserInterface_GCUI = UserInterface.GCUI;

using UserInterface_UIAutomation1 = UserInterface.UIAutomation1;

using UserInterface_UIAutomation2 = UserInterface.UIAutomation2;

using UserInterface_WindowsForm1 = UserInterface.WindowsForm1;

using System;

namespace UserInterface.Project
{
// Project-8D66C4BD61C0112
/// <summary>
/// OpenSpan project.
/// </summary>
[OpenSpan.Design.TargetEnvironmentAttribute(OpenSpan.Design.TargetEnvironment.Driver)]
[OpenSpan.Design.ComponentIdentityAttribute("Project-8D66C4BD61C0112")]
[OpenSpan.Design.DeploymentVersionAttribute("1.0")]
[OpenSpan.Design.ProjectDescriptorAttribute(OpenSpan.Design.ProjectDescriptorType.Present)]
public sealed class UserInterface : OpenSpan.Runtime.RuntimeProject
{
	
	public UserInterface() : 
			base()
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.UserInterface_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public UserInterface(System.ComponentModel.ISynchronizeInvoke syncObject) : 
			base(syncObject)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.UserInterface_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public UserInterface(System.IServiceProvider serviceProvider) : 
			base(serviceProvider)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.UserInterface_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public UserInterface(bool initializeScout) : 
			base(initializeScout)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.UserInterface_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	private UserInterface(System.IServiceProvider serviceProvider, OpenSpan.Runtime.RuntimeHostCommandLineHelper commandLineHelper, OpenSpan.Deployment.DeploymentManifest deploymentManifest) : 
			base(serviceProvider, commandLineHelper, deploymentManifest)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.UserInterface_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	private void UserInterface_Initialize()
	{
		this.mId = new OpenSpan.Design.ComponentIdentity("Project-8D66C4BD61C0112");
		this.mVersion = new System.Version("8.0.1096.0");
		this.mDeploymentVersion = "1.0";
		this.mTransformationVersion = new System.Version("8.0.1026.0");
		this.mTargetEnvironment = OpenSpan.Design.TargetEnvironment.Driver;
		this.mInteractionConfigXml = @"<Interaction >

	<Context>
		<Value Name=""Name"" Type=""String"" Default=""""/>
		<Value Name=""ActNum"" Type=""Number"" Default=""1000""/>
		<Value Name=""Address"" Type=""String"" Default=""1000 Main St""/>
		<Value Name=""City"" Type=""String"" Default=""Atlanta""/>
		<Value Name=""State"" Type=""String"" Default=""GA""/>
		<Value Name=""Zipcode"" Type=""String"" Default=""00000""/>		
	</Context>



	<Activities>
		<Activity Name=""GetCustomerInformation"">
		</Activity>
		<Activity Name=""UpdateDisplay"">
		</Activity>
		<Activity Name=""ActiveMDIWindow"">
			<Value Name=""AccountNumber"" Type=""String""/>
		</Activity>		
	</Activities>
	
</Interaction>
";
	}
	
	// GlobalContainer-8D66C51F4CAC0FC
	public UserInterface_GCUI GCUI
	{
		get
		{
			return ((UserInterface_GCUI)(this["GCUI"]));
		}
	}
	
	// Automator-8D66CB1D8006848
	public UserInterface_UIAutomation1 UIAutomation1
	{
		get
		{
			return ((UserInterface_UIAutomation1)(this["UIAutomation1"]));
		}
	}
	
	// Automator-8D66CB7DE1E6DBE
	public UserInterface_UIAutomation2 UIAutomation2
	{
		get
		{
			return ((UserInterface_UIAutomation2)(this["UIAutomation2"]));
		}
	}
	
	// DesignForm-8D66C4BE51297C5
	public UserInterface_WindowsForm1 WindowsForm1
	{
		get
		{
			return ((UserInterface_WindowsForm1)(this["WindowsForm1"]));
		}
	}
}

}

