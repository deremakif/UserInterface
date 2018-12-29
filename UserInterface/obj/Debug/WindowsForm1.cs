using System;

namespace UserInterface
{
/// <summary>
/// OpenSpan design component.
/// </summary>
// DesignForm-8D66C4BE51297C5
[OpenSpan.Design.ComponentIdentityAttribute("DesignForm-8D66C4BE51297C5")]
[System.ComponentModel.ToolboxItemAttribute(false)]
[OpenSpan.Runtime.RuntimeReferenceAttribute("System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c5619" +
	"34e089")]
public sealed class WindowsForm1 : OpenSpan.Design.DesignForm
{
	
	[OpenSpan.Design.ComponentIdentityAttribute("DesignForm-8D66C4BE51297C5\\Label-8D66C4E198C31BC")]
	public System.Windows.Forms.Label label6;
	
	[OpenSpan.Design.ComponentIdentityAttribute("DesignForm-8D66C4BE51297C5\\TextBox-8D66C4E198DB838")]
	public System.Windows.Forms.TextBox txtZip;
	
	[OpenSpan.Design.ComponentIdentityAttribute("DesignForm-8D66C4BE51297C5\\Label-8D66C4C72B4F6D3")]
	public System.Windows.Forms.Label label5;
	
	[OpenSpan.Design.ComponentIdentityAttribute("DesignForm-8D66C4BE51297C5\\TextBox-8D66C4C72B6CB56")]
	public System.Windows.Forms.TextBox txtState;
	
	[OpenSpan.Design.ComponentIdentityAttribute("DesignForm-8D66C4BE51297C5\\Label-8D66C4C6FB56AD4")]
	public System.Windows.Forms.Label label4;
	
	[OpenSpan.Design.ComponentIdentityAttribute("DesignForm-8D66C4BE51297C5\\TextBox-8D66C4C6FB73F63")]
	public System.Windows.Forms.TextBox txtCity;
	
	[OpenSpan.Design.ComponentIdentityAttribute("DesignForm-8D66C4BE51297C5\\Label-8D66C4C6CA7C2E7")]
	public System.Windows.Forms.Label label3;
	
	[OpenSpan.Design.ComponentIdentityAttribute("DesignForm-8D66C4BE51297C5\\TextBox-8D66C4C6CA996A9")]
	public System.Windows.Forms.TextBox txtAddress;
	
	[OpenSpan.Design.ComponentIdentityAttribute("DesignForm-8D66C4BE51297C5\\Label-8D66C4C4D154595")]
	public System.Windows.Forms.Label label2;
	
	[OpenSpan.Design.ComponentIdentityAttribute("DesignForm-8D66C4BE51297C5\\ComboBox-8D66C4C1810BB05")]
	public System.Windows.Forms.ComboBox cmbAccountNo;
	
	[OpenSpan.Design.ComponentIdentityAttribute("DesignForm-8D66C4BE51297C5\\TextBox-8D66C4C081BB5B1")]
	public System.Windows.Forms.TextBox txtName;
	
	[OpenSpan.Design.ComponentIdentityAttribute("DesignForm-8D66C4BE51297C5\\Label-8D66C4C045288ED")]
	public System.Windows.Forms.Label label1;
	
	public WindowsForm1()
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Setup field members
		// 
		this.label6 = new System.Windows.Forms.Label();
		this.txtZip = new System.Windows.Forms.TextBox();
		this.label5 = new System.Windows.Forms.Label();
		this.txtState = new System.Windows.Forms.TextBox();
		this.label4 = new System.Windows.Forms.Label();
		this.txtCity = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.txtAddress = new System.Windows.Forms.TextBox();
		this.label2 = new System.Windows.Forms.Label();
		this.cmbAccountNo = new System.Windows.Forms.ComboBox();
		this.txtName = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.SuspendLayout();
		// 
		// Initialize design component
		// 
		this.Initialize();
		// 
		// Set design component Id
		// 
		this.Id = new OpenSpan.Design.ComponentIdentity("DesignForm-8D66C4BE51297C5");
		// 
		// Set component Ids
		// 
		this.SetId(this.label6, new OpenSpan.Design.ComponentIdentity("Label-8D66C4E198C31BC"));
		this.SetId(this.txtZip, new OpenSpan.Design.ComponentIdentity("TextBox-8D66C4E198DB838"));
		this.SetId(this.label5, new OpenSpan.Design.ComponentIdentity("Label-8D66C4C72B4F6D3"));
		this.SetId(this.txtState, new OpenSpan.Design.ComponentIdentity("TextBox-8D66C4C72B6CB56"));
		this.SetId(this.label4, new OpenSpan.Design.ComponentIdentity("Label-8D66C4C6FB56AD4"));
		this.SetId(this.txtCity, new OpenSpan.Design.ComponentIdentity("TextBox-8D66C4C6FB73F63"));
		this.SetId(this.label3, new OpenSpan.Design.ComponentIdentity("Label-8D66C4C6CA7C2E7"));
		this.SetId(this.txtAddress, new OpenSpan.Design.ComponentIdentity("TextBox-8D66C4C6CA996A9"));
		this.SetId(this.label2, new OpenSpan.Design.ComponentIdentity("Label-8D66C4C4D154595"));
		this.SetId(this.cmbAccountNo, new OpenSpan.Design.ComponentIdentity("ComboBox-8D66C4C1810BB05"));
		this.SetId(this.txtName, new OpenSpan.Design.ComponentIdentity("TextBox-8D66C4C081BB5B1"));
		this.SetId(this.label1, new OpenSpan.Design.ComponentIdentity("Label-8D66C4C045288ED"));
		// 
		// WindowsForm1
		// 
		this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.SystemColors.Control;
		this.ClientSize = new System.Drawing.Size(483, 309);
		// 
		// label6
		// 
		this.label6.AutoSize = true;
		this.label6.ImageKey = "(none)";
		this.label6.Location = new System.Drawing.Point(43, 185);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(22, 13);
		this.label6.TabIndex = 11;
		this.label6.Text = "Zip";
		// 
		// txtZip
		// 
		this.txtZip.Location = new System.Drawing.Point(142, 178);
		this.txtZip.Name = "txtZip";
		this.txtZip.TabIndex = 10;
		// 
		// label5
		// 
		this.label5.AutoSize = true;
		this.label5.ImageKey = "(none)";
		this.label5.Location = new System.Drawing.Point(43, 159);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(32, 13);
		this.label5.TabIndex = 9;
		this.label5.Text = "State";
		// 
		// txtState
		// 
		this.txtState.Location = new System.Drawing.Point(142, 152);
		this.txtState.Name = "txtState";
		this.txtState.TabIndex = 8;
		// 
		// label4
		// 
		this.label4.AutoSize = true;
		this.label4.ImageKey = "(none)";
		this.label4.Location = new System.Drawing.Point(43, 133);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(24, 13);
		this.label4.TabIndex = 7;
		this.label4.Text = "City";
		// 
		// txtCity
		// 
		this.txtCity.Location = new System.Drawing.Point(142, 126);
		this.txtCity.Name = "txtCity";
		this.txtCity.TabIndex = 6;
		// 
		// label3
		// 
		this.label3.AutoSize = true;
		this.label3.ImageKey = "(none)";
		this.label3.Location = new System.Drawing.Point(43, 107);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(45, 13);
		this.label3.TabIndex = 5;
		this.label3.Text = "Address";
		// 
		// txtAddress
		// 
		this.txtAddress.Location = new System.Drawing.Point(142, 100);
		this.txtAddress.Name = "txtAddress";
		this.txtAddress.TabIndex = 4;
		// 
		// label2
		// 
		this.label2.AutoSize = true;
		this.label2.ImageKey = "(none)";
		this.label2.Location = new System.Drawing.Point(43, 81);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(35, 13);
		this.label2.TabIndex = 3;
		this.label2.Text = "Name";
		// 
		// cmbAccountNo
		// 
		this.cmbAccountNo.FormattingEnabled = true;
		this.cmbAccountNo.Location = new System.Drawing.Point(139, 22);
		this.cmbAccountNo.Name = "cmbAccountNo";
		this.cmbAccountNo.TabIndex = 2;
		// 
		// txtName
		// 
		this.txtName.Location = new System.Drawing.Point(142, 74);
		this.txtName.Name = "txtName";
		this.txtName.TabIndex = 1;
		// 
		// label1
		// 
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(43, 31);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(87, 13);
		this.label1.TabIndex = 0;
		this.label1.Text = "Account Number";
		this.Controls.Add(this.label6);
		this.Controls.Add(this.txtZip);
		this.Controls.Add(this.label5);
		this.Controls.Add(this.txtState);
		this.Controls.Add(this.label4);
		this.Controls.Add(this.txtCity);
		this.Controls.Add(this.label3);
		this.Controls.Add(this.txtAddress);
		this.Controls.Add(this.label2);
		this.Controls.Add(this.cmbAccountNo);
		this.Controls.Add(this.txtName);
		this.Controls.Add(this.label1);
		this.Location = new System.Drawing.Point(433, 190);
		this.Name = "WindowsForm1";
		this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Design Form";
		this.Visible = false;
		this.ResumeLayout(false);
		this.PerformLayout();
		// 
		// Add components
		// 
		this.mComponents = new System.Collections.Generic.List<System.ComponentModel.IComponent>(20);
		this.Components.Add(this.label6);
		this.Components.Add(this.txtZip);
		this.Components.Add(this.label5);
		this.Components.Add(this.txtState);
		this.Components.Add(this.label4);
		this.Components.Add(this.txtCity);
		this.Components.Add(this.label3);
		this.Components.Add(this.txtAddress);
		this.Components.Add(this.label2);
		this.Components.Add(this.cmbAccountNo);
		this.Components.Add(this.txtName);
		this.Components.Add(this.label1);
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
	
	internal System.Windows.Forms.Label Create_label6(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		System.Windows.Forms.Label label6 = new System.Windows.Forms.Label();
		this.SetId(label6, new OpenSpan.Design.ComponentIdentity("Label-8D66C4E198C31BC"));
		label6.AutoSize = true;
		label6.ImageKey = "(none)";
		label6.Location = new System.Drawing.Point(43, 185);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(22, 13);
		label6.TabIndex = 11;
		label6.Text = "Zip";
		// 
		// Result
		// 
		return label6;
	}
	
	internal System.Windows.Forms.TextBox Create_txtZip(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		System.Windows.Forms.TextBox txtZip = new System.Windows.Forms.TextBox();
		this.SetId(txtZip, new OpenSpan.Design.ComponentIdentity("TextBox-8D66C4E198DB838"));
		txtZip.Location = new System.Drawing.Point(142, 178);
		txtZip.Name = "txtZip";
		txtZip.TabIndex = 10;
		// 
		// Result
		// 
		return txtZip;
	}
	
	internal System.Windows.Forms.Label Create_label5(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		System.Windows.Forms.Label label5 = new System.Windows.Forms.Label();
		this.SetId(label5, new OpenSpan.Design.ComponentIdentity("Label-8D66C4C72B4F6D3"));
		label5.AutoSize = true;
		label5.ImageKey = "(none)";
		label5.Location = new System.Drawing.Point(43, 159);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(32, 13);
		label5.TabIndex = 9;
		label5.Text = "State";
		// 
		// Result
		// 
		return label5;
	}
	
	internal System.Windows.Forms.TextBox Create_txtState(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		System.Windows.Forms.TextBox txtState = new System.Windows.Forms.TextBox();
		this.SetId(txtState, new OpenSpan.Design.ComponentIdentity("TextBox-8D66C4C72B6CB56"));
		txtState.Location = new System.Drawing.Point(142, 152);
		txtState.Name = "txtState";
		txtState.TabIndex = 8;
		// 
		// Result
		// 
		return txtState;
	}
	
	internal System.Windows.Forms.Label Create_label4(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		System.Windows.Forms.Label label4 = new System.Windows.Forms.Label();
		this.SetId(label4, new OpenSpan.Design.ComponentIdentity("Label-8D66C4C6FB56AD4"));
		label4.AutoSize = true;
		label4.ImageKey = "(none)";
		label4.Location = new System.Drawing.Point(43, 133);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(24, 13);
		label4.TabIndex = 7;
		label4.Text = "City";
		// 
		// Result
		// 
		return label4;
	}
	
	internal System.Windows.Forms.TextBox Create_txtCity(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		System.Windows.Forms.TextBox txtCity = new System.Windows.Forms.TextBox();
		this.SetId(txtCity, new OpenSpan.Design.ComponentIdentity("TextBox-8D66C4C6FB73F63"));
		txtCity.Location = new System.Drawing.Point(142, 126);
		txtCity.Name = "txtCity";
		txtCity.TabIndex = 6;
		// 
		// Result
		// 
		return txtCity;
	}
	
	internal System.Windows.Forms.Label Create_label3(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		System.Windows.Forms.Label label3 = new System.Windows.Forms.Label();
		this.SetId(label3, new OpenSpan.Design.ComponentIdentity("Label-8D66C4C6CA7C2E7"));
		label3.AutoSize = true;
		label3.ImageKey = "(none)";
		label3.Location = new System.Drawing.Point(43, 107);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(45, 13);
		label3.TabIndex = 5;
		label3.Text = "Address";
		// 
		// Result
		// 
		return label3;
	}
	
	internal System.Windows.Forms.TextBox Create_txtAddress(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		System.Windows.Forms.TextBox txtAddress = new System.Windows.Forms.TextBox();
		this.SetId(txtAddress, new OpenSpan.Design.ComponentIdentity("TextBox-8D66C4C6CA996A9"));
		txtAddress.Location = new System.Drawing.Point(142, 100);
		txtAddress.Name = "txtAddress";
		txtAddress.TabIndex = 4;
		// 
		// Result
		// 
		return txtAddress;
	}
	
	internal System.Windows.Forms.Label Create_label2(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		System.Windows.Forms.Label label2 = new System.Windows.Forms.Label();
		this.SetId(label2, new OpenSpan.Design.ComponentIdentity("Label-8D66C4C4D154595"));
		label2.AutoSize = true;
		label2.ImageKey = "(none)";
		label2.Location = new System.Drawing.Point(43, 81);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(35, 13);
		label2.TabIndex = 3;
		label2.Text = "Name";
		// 
		// Result
		// 
		return label2;
	}
	
	internal System.Windows.Forms.ComboBox Create_cmbAccountNo(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		System.Windows.Forms.ComboBox cmbAccountNo = new System.Windows.Forms.ComboBox();
		this.SetId(cmbAccountNo, new OpenSpan.Design.ComponentIdentity("ComboBox-8D66C4C1810BB05"));
		cmbAccountNo.FormattingEnabled = true;
		cmbAccountNo.Location = new System.Drawing.Point(139, 22);
		cmbAccountNo.Name = "cmbAccountNo";
		cmbAccountNo.TabIndex = 2;
		// 
		// Result
		// 
		return cmbAccountNo;
	}
	
	internal System.Windows.Forms.TextBox Create_txtName(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		System.Windows.Forms.TextBox txtName = new System.Windows.Forms.TextBox();
		this.SetId(txtName, new OpenSpan.Design.ComponentIdentity("TextBox-8D66C4C081BB5B1"));
		txtName.Location = new System.Drawing.Point(142, 74);
		txtName.Name = "txtName";
		txtName.TabIndex = 1;
		// 
		// Result
		// 
		return txtName;
	}
	
	internal System.Windows.Forms.Label Create_label1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		System.Windows.Forms.Label label1 = new System.Windows.Forms.Label();
		this.SetId(label1, new OpenSpan.Design.ComponentIdentity("Label-8D66C4C045288ED"));
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(43, 31);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(87, 13);
		label1.TabIndex = 0;
		label1.Text = "Account Number";
		// 
		// Result
		// 
		return label1;
	}
}

}

