' Bongani Computers Source Code
Imports System.Globalization
Public Class Form1
    Dim strName As String
    Dim strSurname As String

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click
        Dim decSubtotal As Decimal
        Dim decVatRate As Decimal = 0.15
        Dim decVatAmount As Decimal
        Dim dectotal As Decimal
        Dim decTotalMarkup As Decimal

        'Conversion of Variables  to Control Names
        strName = CStr(txtName.Text)
        strSurname = CStr(txtSurname.Text)

        lstdisplay.Items.Clear()

        'Display the Output
        lstdisplay.Items.Add("QUOTATION for" + " " + strSurname + "," + strName)
        lstdisplay.Items.Add("___________________________________________________________________________________________________________________")

        'Condition Statements for Computing Devices Radio Buttons
        If radPersonalComputer.Checked = True Then
            lstdisplay.Items.Add("Personal Computer:Bongani Computers")                                                                                                                                                                                                                      
            lstdisplay.Items.Add("System board: B550M Pro4 AM4")
            lstdisplay.Items.Add("CPU: Intel S1200 Core i5 11400 TRAY 6*26 65W 11Gen @ 4.4 GHz")
            lstdisplay.Items.Add("RAM: DDR4")
            lstdisplay.Items.Add("HDD: 1TB")
            lstdisplay.Items.Add(" " + "R6009.35".PadLeft(220))

            decSubtotal += 6009.35D
            decTotalMarkup += 6009.35D * 0.4


        ElseIf radLaptop.Checked = True Then
            lstdisplay.Items.Add("Laptop:Dell Latitude 5420 intel core i5")                                                                                                                                                                                                         
            lstdisplay.Items.Add("CPU 11th Gen Core i5-1185G7 3.0GHz")
            lstdisplay.Items.Add("SSD: 256GB M.2 Solid State Drive SSD")
            lstdisplay.Items.Add("RAM: 8 GB DDR4 3200 MHz Memory")
            lstdisplay.Items.Add("Screen Length: 14 inch FHD 1920 x 1080 display")
            lstdisplay.Items.Add("Graphics Card: Integrated Intel Iris Xe Graphics")
            lstdisplay.Items.Add("Operating System: Windows 10 Pro Operating System")
            lstdisplay.Items.Add("Application Software: Microsoft Office 2019 Pro Plus")
            lstdisplay.Items.Add(" " + "R8500.00".PadLeft(220))

            decSubtotal += 8500D
            decTotalMarkup += 8500D * 0.4

        ElseIf radTablet.Checked = True Then
            lstdisplay.Items.Add("Tablet:Samsung Galaxy Tab A9+ 5G 64GB Graphite")                                                                                                                                                                                     
            lstdisplay.Items.Add("Screen: 11 TFT (1920x1200:90Hz) WUXGA")
            lstdisplay.Items.Add("Storage and Memory: 64GB storage and 4GB RAM")
            lstdisplay.Items.Add("Camera: Rear 8MP")
            lstdisplay.Items.Add("Camera: Front 5MP")
            lstdisplay.Items.Add("Battery: 7040mAh")
            lstdisplay.Items.Add("OS: Android 13")
            lstdisplay.Items.Add("Security: Face recognition, PIN, Password")
            lstdisplay.Items.Add("Warranty: 2 year warranty")
            lstdisplay.Items.Add(" " + "R4999.00".PadLeft(220))

            decSubtotal += 4999D
            decTotalMarkup += 4999D * 0.4

        ElseIf radSmartphone.Checked = True Then
            lstdisplay.Items.Add("Smartphone:SAMSUNG A05s 64GB SM-A057F/DS LIGHT VIOLET LTE AFA")                                                                                                                                                               
            lstdisplay.Items.Add("Screen: 6.5-inch FHD+ display")
            lstdisplay.Items.Add("Memory: MicroSD expandable up to 1TB")
            lstdisplay.Items.Add("Charger: C-type super fast 25W charging support")
            lstdisplay.Items.Add("Camera:  50MP (F1.8) main camera with auto focus + 2MP (F2.4) depth camera + 2MP (F2.4) macro camera, 13MP (F2.0) front camera")
            lstdisplay.Items.Add("Processor: Qualcomm Snapdragon 680 Processor 2.4GHz, 1.9GHz 12nm Octa-Processor")
            lstdisplay.Items.Add(" " + "R2545.00".PadLeft(220))

            decSubtotal += 2545D
            decTotalMarkup += 2545D * 0.4
        End If


        'Condition Statements for Computer & Peripherals Checkboxes
        'Computer
        If chkComputer.Checked = True Then
            lstdisplay.Items.Add("Personal Computer:Bongani Computers")
            lstdisplay.Items.Add("System board: B550M Pro4 AM4")
            lstdisplay.Items.Add("CPU: Intel S1200 Core i5 11400 TRAY 6*26 65W 11Gen @ 4.4 GHz")
            lstdisplay.Items.Add("RAM: DDR4")
            lstdisplay.Items.Add("HDD: 1TB")
            lstdisplay.Items.Add(" " + "R6009.35".PadLeft(220))

            decSubtotal += 6009.35D
            decTotalMarkup += 6009.35D * 0.4
        End If


        'GraphicsCard
        If chkGraphicsCard.Checked = True Then
            lstdisplay.Items.Add("Graphics card")
            lstdisplay.Items.Add(" " + "R2607.83".PadLeft(220))

            decSubtotal += 2545.83D
            decTotalMarkup += 2545.83D * 0.4
        End If

        'Monitor
        If chkMonitor.Checked = True Then
            lstdisplay.Items.Add("Monitor")
            lstdisplay.Items.Add(" " + "R520.87".PadLeft(221))

            decSubtotal += 520.87D
            decTotalMarkup += 520.87D * 0.4
        End If

        'Keyboard
        If chkKeyboard.Checked = True Then
            lstdisplay.Items.Add("Keyboard")
            lstdisplay.Items.Add(" " + "R134.00".PadLeft(221))

            decSubtotal += 134D
            decTotalMarkup += 134D * 0.4
        End If

        'Mouse
        If chkMouse.Checked = True Then
            lstdisplay.Items.Add("Mouse")
            lstdisplay.Items.Add(" " + "R86.09".PadLeft(222))

            decSubtotal += 86.09D
            decTotalMarkup += 86.09D * 0.4
        End If



        'Condition Statements for Computer & Peripherals Comboboxes
        'Additional DDR4 RAM
        Select Case cmbAdditionalDDR4.SelectedIndex
            Case 0
                lstdisplay.Items.Add("Additional Ram 0 x 1580.87")
                lstdisplay.Items.Add(" " + "R0.00".PadLeft(223))

                decSubtotal += 0.00D
                decTotalMarkup += 0.00D * 0.4
            Case 1
                lstdisplay.Items.Add("Additional Ram 1 x 1580.87")
                lstdisplay.Items.Add(" " + "R1580.87".PadLeft(220))

                decSubtotal += 1580.87D
                decTotalMarkup += 1580.87D * 0.4
            Case 2
                lstdisplay.Items.Add("Additional Ram 2 x 1580.87")
                lstdisplay.Items.Add(" " + "R3161.74".PadLeft(220))

                decSubtotal += 3161.74D
                decTotalMarkup += 3161.74D * 0.4
            Case 3
                lstdisplay.Items.Add("Additional Ram 3 x 1580.87")
                lstdisplay.Items.Add(" " + "R4742.61".PadLeft(220))

                decSubtotal += 4742.61D
                decTotalMarkup += 4742.61D * 0.4
            Case 4
                lstdisplay.Items.Add("Additional Ram 4 x 1580.87")
                lstdisplay.Items.Add(" " + "R6323.48".PadLeft(220))

                decSubtotal += 6323.48D
                decTotalMarkup += 6323.48D * 0.4
            Case 5
                lstdisplay.Items.Add("Additional Ram 5 x 1580.87")
                lstdisplay.Items.Add(" " + "R7904.35".PadLeft(220))

                decSubtotal += 7904.35D
                decTotalMarkup += 7904.35D * 0.4
        End Select

        'Additional HDD
        Select Case cmbAdditionalRam.SelectedIndex
            Case 0
                lstdisplay.Items.Add("Additional HDD 0 x 583.48")
                lstdisplay.Items.Add(" " + "R0.00".PadLeft(223))

                decSubtotal += 0.00D
                decTotalMarkup += 0.00D * 0.4
            Case 1
                lstdisplay.Items.Add("Additional HDD 1 x 583.48")
                lstdisplay.Items.Add(" " + "R583.48".PadLeft(220))

                decSubtotal += 583.48D
                decTotalMarkup += 583.48D * 0.4
            Case 2
                lstdisplay.Items.Add("Additional HDD 2 x 583.48")
                lstdisplay.Items.Add(" " + "R1166.96".PadLeft(220))

                decSubtotal += 1166.96D
                decTotalMarkup += 1166.96D * 0.4
            Case 3
                lstdisplay.Items.Add("Additional HDD 3 x 583.48")
                lstdisplay.Items.Add(" " + "R1750.44".PadLeft(220))

                decSubtotal += 1750.44D
                decTotalMarkup += 1750.44D * 0.4
            Case 4
                lstdisplay.Items.Add("Additional HDD 4 x 583.48")
                lstdisplay.Items.Add(" " + "R2333.92".PadLeft(220))

                decSubtotal += 2333.92D
                decTotalMarkup += 2333.92D * 0.4
            Case 5
                lstdisplay.Items.Add("Additional HDD 5 x 583.48")
                lstdisplay.Items.Add("R2917.40".PadLeft(220))

                decSubtotal += 2917.4D
                decTotalMarkup += 2917.4D * 0.4
        End Select

        'Calculate Total Sub, Total Markup, Vat Amount and Total
        decVatAmount = (decTotalMarkup + decSubtotal) * decVatRate
        dectotal = decSubtotal + decVatAmount + decTotalMarkup



        'Display the Output
        lstdisplay.Items.Add("___________________________________________________________________________________________________________________")
        lstdisplay.Items.Add("Total Sub" + decSubtotal.ToString("C2", CultureInfo.CreateSpecificCulture("en-ZA")).PadLeft(204))
        lstdisplay.Items.Add("Total Markup" + decTotalMarkup.ToString("C2", CultureInfo.CreateSpecificCulture("en-ZA")).PadLeft(200))
        lstdisplay.Items.Add("VAT Amount" + decVatAmount.ToString("C2", CultureInfo.CreateSpecificCulture("en-ZA")).PadLeft(201))
        lstdisplay.Items.Add("Total" + dectotal.ToString("C2", CultureInfo.CreateSpecificCulture("en-ZA")).PadLeft(212))

    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Exit the Program
        Me.Close()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clearing the text boxes
        txtName.Text = ""
        txtSurname.Text = ""

        'Clearing the radio buttons
        radPersonalComputer.Checked = False
        radLaptop.Checked = False
        radTablet.Checked = False
        radSmartphone.Checked = False

        'Clearing the checkboxes
        chkComputer.Checked = False
        chkGraphicsCard.Checked = False
        chkMonitor.Checked = False
        chkKeyboard.Checked = False
        chkMouse.Checked = False

        'Reset the combo boxes
        cmbAdditionalDDR4.SelectedIndex = 0
        cmbAdditionalRam.SelectedIndex = 0

        'Clearing the display
        lstdisplay.Items.Clear()

        'Resetting all the variables
        strName = ""
        strSurname = ""
    End Sub
    End Class
