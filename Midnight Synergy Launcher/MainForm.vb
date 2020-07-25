'
' Created by SharpDevelop.
' User: nasko222
' Date: 07-Dec-19
' Time: 3:15 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System.IO

Public Partial Class MainForm
Public Dim editor As Boolean
Public Dim gamefiles As Boolean
Public Dim speedrun As Boolean	

Public Dim TOW_Game As String
Public Dim TOW_Folder As String
Public Dim TOW_Editor As String
Public Dim TOW_Folder_Editor As String
Public Dim WSW As String
Public Dim WSW_Folder As String
Public Dim RTW_Game As String
Public Dim RTW_Editor As String
Public Dim RTW_Folder As String
Public Dim KQ_Game As String
Public Dim KQ_Editor As String
Public Dim KQ_Folder As String
Public Dim WA1_Game As String
Public Dim WA1_Folder As String
Public Dim WA1_Game_Speedrun As String
Public Dim WA1_Folder_Speedrun As String
Public Dim WA1_Editor As String
Public Dim WA1_Folder_Editor As String
Public Dim WA2_Game As String
Public Dim WA2_Folder As String
Public Dim WA2_Game_Speedrun As String
Public Dim WA2_Folder_Speedrun As String
Public Dim WA2_Editor As String
Public Dim WA2_Folder_Editor As String
Public Dim WA3_Game As String
Public Dim WA3_Folder As String
Public Dim WA3_Game_Speedrun As String
Public Dim WA3_Folder_Speedrun As String
Public Dim WA3_Editor As String
Public Dim WA3_Folder_Editor As String
Public Dim PQ As String
Public Dim PQ_Folder As String



	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub PictureBox1Click(sender As Object, e As EventArgs)
		End
	End Sub
	
	Sub Tow1Click(sender As Object, e As EventArgs)
		If editor And Not gamefiles Then
			Using MyProcess As New Process
                MyProcess.StartInfo.UseShellExecute = False
                MyProcess.StartInfo.FileName = TOW_Editor
                MyProcess.StartInfo.WorkingDirectory = Path.GetDirectoryName(MyProcess.StartInfo.FileName)
                MyProcess.Start()
            End Using
		ElseIf gamefiles Then
			If editor Then
				System.Diagnostics.Process.Start(TOW_Folder_Editor)
			ElseIf speedrun
				MessageBox.Show("null")
			Else
				System.Diagnostics.Process.Start(TOW_Folder)
			End If
		ElseIf speedrun
			MessageBox.Show("null")
		Else
			Using MyProcess As New Process
                MyProcess.StartInfo.UseShellExecute = False
                MyProcess.StartInfo.FileName = TOW_Game
                MyProcess.StartInfo.WorkingDirectory = Path.GetDirectoryName(MyProcess.StartInfo.FileName)
                MyProcess.Start()
            End Using
		End If
	End Sub
	
	Sub Tow2Click(sender As Object, e As EventArgs)
		If editor And Not gamefiles Then
			MessageBox.Show("null")
		ElseIf gamefiles Then
			If editor Then
				MessageBox.Show("null")
			ElseIf speedrun
				MessageBox.Show("null")
			Else
				System.Diagnostics.Process.Start(WSW_Folder)
			End If
		ElseIf speedrun
			MessageBox.Show("null")
		Else
			Using MyProcess As New Process
                MyProcess.StartInfo.UseShellExecute = False
                MyProcess.StartInfo.FileName = WSW
                MyProcess.StartInfo.WorkingDirectory = Path.GetDirectoryName(MyProcess.StartInfo.FileName)
                MyProcess.Start()
            End Using
		End If
	End Sub
	
	Sub Tow3Click(sender As Object, e As EventArgs)
		If editor And Not gamefiles Then
			Using MyProcess As New Process
                MyProcess.StartInfo.UseShellExecute = False
                MyProcess.StartInfo.FileName = RTW_Editor
                MyProcess.StartInfo.WorkingDirectory = Path.GetDirectoryName(MyProcess.StartInfo.FileName)
                MyProcess.Start()
            End Using
		ElseIf gamefiles Then
			If editor Then
				System.Diagnostics.Process.Start(RTW_Folder)
			ElseIf speedrun
				MessageBox.Show("null")
			Else
				System.Diagnostics.Process.Start(RTW_Folder)
			End If
		ElseIf speedrun
			MessageBox.Show("null")
		Else
			Using MyProcess As New Process
                MyProcess.StartInfo.UseShellExecute = False
                MyProcess.StartInfo.FileName = RTW_Game
                MyProcess.StartInfo.WorkingDirectory = Path.GetDirectoryName(MyProcess.StartInfo.FileName)
                MyProcess.Start()
            End Using
		End If
	End Sub
	
	Sub Tow4Click(sender As Object, e As EventArgs)
		If editor And Not gamefiles Then
			Using MyProcess As New Process
                MyProcess.StartInfo.UseShellExecute = False
                MyProcess.StartInfo.FileName = KQ_Editor
                MyProcess.StartInfo.WorkingDirectory = Path.GetDirectoryName(MyProcess.StartInfo.FileName)
                MyProcess.Start()
            End Using
		ElseIf gamefiles Then
			If editor Then
				System.Diagnostics.Process.Start(KQ_Folder)
			ElseIf speedrun
				MessageBox.Show("null")
			Else
				System.Diagnostics.Process.Start(KQ_Folder)
			End If
		ElseIf speedrun
			MessageBox.Show("null")
		Else
			Using MyProcess As New Process
                MyProcess.StartInfo.UseShellExecute = False
                MyProcess.StartInfo.FileName = KQ_Game
                MyProcess.StartInfo.WorkingDirectory = Path.GetDirectoryName(MyProcess.StartInfo.FileName)
                MyProcess.Start()
            End Using
		End If
	End Sub
	
	Sub Wa1Click(sender As Object, e As EventArgs)
        If editor And Not gamefiles Then
            Using MyProcess As New Process
                MyProcess.StartInfo.UseShellExecute = False
                MyProcess.StartInfo.FileName = WA1_Editor
                MyProcess.StartInfo.WorkingDirectory = Path.GetDirectoryName(MyProcess.StartInfo.FileName)
                MyProcess.Start()
            End Using
        ElseIf gamefiles Then
            If editor Then
                System.Diagnostics.Process.Start(WA1_Folder_Editor)
            ElseIf speedrun Then
                System.Diagnostics.Process.Start(WA1_Folder_Speedrun)
            Else
                System.Diagnostics.Process.Start(WA1_Folder)
            End If
        ElseIf speedrun Then
            Using MyProcess As New Process
                MyProcess.StartInfo.UseShellExecute = False
                MyProcess.StartInfo.FileName = WA1_Game_Speedrun
                MyProcess.StartInfo.WorkingDirectory = Path.GetDirectoryName(MyProcess.StartInfo.FileName)
                MyProcess.Start()
            End Using
        Else
            Using MyProcess As New Process
                MyProcess.StartInfo.UseShellExecute = False
                MyProcess.StartInfo.FileName = WA1_Game
                MyProcess.StartInfo.WorkingDirectory = Path.GetDirectoryName(MyProcess.StartInfo.FileName)
                MyProcess.Start()
            End Using
        End If
	End Sub
	
	Sub Wa2Click(sender As Object, e As EventArgs)
        If editor And Not gamefiles Then
            Using MyProcess As New Process
                MyProcess.StartInfo.UseShellExecute = False
                MyProcess.StartInfo.FileName = WA2_Editor
                MyProcess.StartInfo.WorkingDirectory = Path.GetDirectoryName(MyProcess.StartInfo.FileName)
                MyProcess.Start()
            End Using
        ElseIf gamefiles Then
            If editor Then
                System.Diagnostics.Process.Start(WA2_Folder_Editor)
            ElseIf speedrun Then
                System.Diagnostics.Process.Start(WA2_Folder_Speedrun)
            Else
                System.Diagnostics.Process.Start(WA2_Folder)
            End If
        ElseIf speedrun Then
            Using MyProcess As New Process
                MyProcess.StartInfo.UseShellExecute = False
                MyProcess.StartInfo.FileName = WA2_Game_Speedrun
                MyProcess.StartInfo.WorkingDirectory = Path.GetDirectoryName(MyProcess.StartInfo.FileName)
                MyProcess.Start()
            End Using
        Else
            Using MyProcess As New Process
                MyProcess.StartInfo.UseShellExecute = False
                MyProcess.StartInfo.FileName = WA2_Game
                MyProcess.StartInfo.WorkingDirectory = Path.GetDirectoryName(MyProcess.StartInfo.FileName)
                MyProcess.Start()
            End Using
        End If
	End Sub
	
	Sub Wa3Click(sender As Object, e As EventArgs)
        If editor And Not gamefiles Then
            Using MyProcess As New Process
                MyProcess.StartInfo.UseShellExecute = False
                MyProcess.StartInfo.FileName = WA3_Editor
                MyProcess.StartInfo.WorkingDirectory = Path.GetDirectoryName(MyProcess.StartInfo.FileName)
                MyProcess.Start()
            End Using
        ElseIf gamefiles Then
            If editor Then
                System.Diagnostics.Process.Start(WA3_Folder_Editor)
            ElseIf speedrun Then
                System.Diagnostics.Process.Start(WA3_Folder_Speedrun)
            Else
                System.Diagnostics.Process.Start(WA3_Folder)
            End If
        ElseIf speedrun Then
            Using MyProcess As New Process
                MyProcess.StartInfo.UseShellExecute = False
                MyProcess.StartInfo.FileName = WA3_Game_Speedrun
                MyProcess.StartInfo.WorkingDirectory = Path.GetDirectoryName(MyProcess.StartInfo.FileName)
                MyProcess.Start()
            End Using
        Else
            Using MyProcess As New Process
                MyProcess.StartInfo.UseShellExecute = False
                MyProcess.StartInfo.FileName = WA3_Game
                MyProcess.StartInfo.WorkingDirectory = Path.GetDirectoryName(MyProcess.StartInfo.FileName)
                MyProcess.Start()
            End Using
        End If
	End Sub
	
	Sub Wa4Click(sender As Object, e As EventArgs)
		If editor And Not gamefiles Then
			MessageBox.Show("null")
		ElseIf gamefiles Then
			If editor Then
				MessageBox.Show("null")
			ElseIf speedrun
				MessageBox.Show("null")
			Else
				System.Diagnostics.Process.Start(PQ_Folder)
			End If
		ElseIf speedrun
			MessageBox.Show("null")
		Else
			Using MyProcess As New Process
                MyProcess.StartInfo.UseShellExecute = False
                MyProcess.StartInfo.FileName = PQ
                MyProcess.StartInfo.WorkingDirectory = Path.GetDirectoryName(MyProcess.StartInfo.FileName)
                MyProcess.Start()
            End Using
		End If
	End Sub
	
	Sub Piccheck1Click(sender As Object, e As EventArgs)
		
		If Piccheck1.BackgroundImage Is Nothing Then
			If Not Piccheck3.BackgroundImage Is buffer1.BackgroundImage Then
				Piccheck1.BackgroundImage = buffer1.BackgroundImage
				editor = True
			End If
		ElseIf Piccheck1.BackgroundImage Is buffer1.BackgroundImage
			Piccheck1.BackgroundImage = Nothing
			editor = False
		End If
	End Sub
	
	Sub Piccheck2Click(sender As Object, e As EventArgs)
		If Piccheck2.BackgroundImage Is Nothing Then
			Piccheck2.BackgroundImage = buffer1.BackgroundImage
			gamefiles = True
		ElseIf Piccheck2.BackgroundImage Is buffer1.BackgroundImage
			Piccheck2.BackgroundImage = Nothing
			gamefiles = False
		End If
	End Sub
	
	Sub Piccheck3Click(sender As Object, e As EventArgs)
		If Piccheck3.BackgroundImage Is Nothing Then
			If Not Piccheck1.BackgroundImage Is buffer1.BackgroundImage Then
				Piccheck3.BackgroundImage = buffer1.BackgroundImage
				speedrun = True
			End If
		ElseIf Piccheck3.BackgroundImage Is buffer1.BackgroundImage
			Piccheck3.BackgroundImage = Nothing
			speedrun = False
		End If
	End Sub
	
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer
    
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove

        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub
    
    Public Function GetSettingItem(ByVal File As String, ByVal Identifier As String) As String
    	Dim S As New IO.StreamReader(File) : Dim Result As String = ""
    	Do While (S.Peek <> -1)
    		Dim Line As String = S.ReadLine
    		If Line.ToLower.StartsWith(Identifier.ToLower & ":") Then
    			Result = Line.Substring(Identifier.Length + 2)
    		End If
    	Loop
    	Return Result
    End Function
    
	
End Class
