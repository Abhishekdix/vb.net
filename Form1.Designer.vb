<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnAddgoods = New System.Windows.Forms.Button()
        Me.btnDeletegoods = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAddgoods
        '
        Me.btnAddgoods.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAddgoods.BackgroundImage = CType(resources.GetObject("btnAddgoods.BackgroundImage"), System.Drawing.Image)
        Me.btnAddgoods.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAddgoods.Location = New System.Drawing.Point(351, 278)
        Me.btnAddgoods.Name = "btnAddgoods"
        Me.btnAddgoods.Size = New System.Drawing.Size(190, 174)
        Me.btnAddgoods.TabIndex = 0
        Me.btnAddgoods.UseVisualStyleBackColor = False
        '
        'btnDeletegoods
        '
        Me.btnDeletegoods.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDeletegoods.BackgroundImage = CType(resources.GetObject("btnDeletegoods.BackgroundImage"), System.Drawing.Image)
        Me.btnDeletegoods.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDeletegoods.Location = New System.Drawing.Point(636, 278)
        Me.btnDeletegoods.Name = "btnDeletegoods"
        Me.btnDeletegoods.Size = New System.Drawing.Size(199, 174)
        Me.btnDeletegoods.TabIndex = 1
        Me.btnDeletegoods.UseVisualStyleBackColor = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCalculate.BackgroundImage = CType(resources.GetObject("btnCalculate.BackgroundImage"), System.Drawing.Image)
        Me.btnCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCalculate.Location = New System.Drawing.Point(923, 278)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(180, 174)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label1.Location = New System.Drawing.Point(406, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(572, 50)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Production Management System" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1390, 700)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnDeletegoods)
        Me.Controls.Add(Me.btnAddgoods)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Name = "Form1"
        Me.Text = "Production Management System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddgoods As Button
    Friend WithEvents btnDeletegoods As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Label1 As Label
End Class
