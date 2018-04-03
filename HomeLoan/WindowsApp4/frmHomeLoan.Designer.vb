<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHomeLoan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblLoanAmount = New System.Windows.Forms.Label()
        Me.lblInterestRate = New System.Windows.Forms.Label()
        Me.lblTerm = New System.Windows.Forms.Label()
        Me.lblMonthlyPayment = New System.Windows.Forms.Label()
        Me.txtPrincipal = New System.Windows.Forms.TextBox()
        Me.txtInterestRate = New System.Windows.Forms.TextBox()
        Me.txtYears = New System.Windows.Forms.TextBox()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblLoanAmount
        '
        Me.lblLoanAmount.AutoSize = True
        Me.lblLoanAmount.Location = New System.Drawing.Point(26, 38)
        Me.lblLoanAmount.Name = "lblLoanAmount"
        Me.lblLoanAmount.Size = New System.Drawing.Size(70, 13)
        Me.lblLoanAmount.TabIndex = 0
        Me.lblLoanAmount.Text = "Loan Amount"
        '
        'lblInterestRate
        '
        Me.lblInterestRate.AutoSize = True
        Me.lblInterestRate.Location = New System.Drawing.Point(26, 75)
        Me.lblInterestRate.Name = "lblInterestRate"
        Me.lblInterestRate.Size = New System.Drawing.Size(68, 13)
        Me.lblInterestRate.TabIndex = 1
        Me.lblInterestRate.Text = "Interest Rate"
        '
        'lblTerm
        '
        Me.lblTerm.AutoSize = True
        Me.lblTerm.Location = New System.Drawing.Point(26, 112)
        Me.lblTerm.Name = "lblTerm"
        Me.lblTerm.Size = New System.Drawing.Size(31, 13)
        Me.lblTerm.TabIndex = 2
        Me.lblTerm.Text = "Term"
        '
        'lblMonthlyPayment
        '
        Me.lblMonthlyPayment.AutoSize = True
        Me.lblMonthlyPayment.Location = New System.Drawing.Point(26, 149)
        Me.lblMonthlyPayment.Name = "lblMonthlyPayment"
        Me.lblMonthlyPayment.Size = New System.Drawing.Size(88, 13)
        Me.lblMonthlyPayment.TabIndex = 3
        Me.lblMonthlyPayment.Text = "Monthly Payment"
        '
        'txtPrincipal
        '
        Me.txtPrincipal.Location = New System.Drawing.Point(166, 35)
        Me.txtPrincipal.Name = "txtPrincipal"
        Me.txtPrincipal.Size = New System.Drawing.Size(100, 20)
        Me.txtPrincipal.TabIndex = 4
        Me.txtPrincipal.Text = "100000"
        Me.txtPrincipal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtInterestRate
        '
        Me.txtInterestRate.Location = New System.Drawing.Point(166, 72)
        Me.txtInterestRate.Name = "txtInterestRate"
        Me.txtInterestRate.Size = New System.Drawing.Size(100, 20)
        Me.txtInterestRate.TabIndex = 5
        Me.txtInterestRate.Text = "5.31"
        Me.txtInterestRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtYears
        '
        Me.txtYears.Location = New System.Drawing.Point(166, 109)
        Me.txtYears.Name = "txtYears"
        Me.txtYears.Size = New System.Drawing.Size(100, 20)
        Me.txtYears.TabIndex = 6
        Me.txtYears.Text = "30"
        Me.txtYears.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPayment
        '
        Me.txtPayment.ForeColor = System.Drawing.Color.Blue
        Me.txtPayment.Location = New System.Drawing.Point(166, 146)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.ReadOnly = True
        Me.txtPayment.Size = New System.Drawing.Size(100, 20)
        Me.txtPayment.TabIndex = 7
        Me.txtPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(191, 202)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'frmHomeLoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 243)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtPayment)
        Me.Controls.Add(Me.txtYears)
        Me.Controls.Add(Me.txtInterestRate)
        Me.Controls.Add(Me.txtPrincipal)
        Me.Controls.Add(Me.lblMonthlyPayment)
        Me.Controls.Add(Me.lblTerm)
        Me.Controls.Add(Me.lblInterestRate)
        Me.Controls.Add(Me.lblLoanAmount)
        Me.Name = "frmHomeLoan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home Loan Payments"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLoanAmount As Label
    Friend WithEvents lblInterestRate As Label
    Friend WithEvents lblTerm As Label
    Friend WithEvents lblMonthlyPayment As Label
    Friend WithEvents txtPrincipal As TextBox
    Friend WithEvents txtInterestRate As TextBox
    Friend WithEvents txtYears As TextBox
    Friend WithEvents txtPayment As TextBox
    Friend WithEvents btnCalculate As Button
End Class
