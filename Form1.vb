Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Net
Imports System.Text

Public Class Form1

    Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, ByVal value As T) As T
        target = value
        Return value
    End Function

    Private Sub CheckRegExp()

        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(ListBox1.SelectedItem)
        Dim response As System.Net.HttpWebResponse = request.GetResponse

        Dim SiteSource As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
        Dim UseSource As String = SiteSource.ReadToEnd



        Dim SplitVar As Integer
        Dim Port As Boolean = False
        Dim useport As Boolean = False
        Dim portval As String

        Dim reg As Regex

        If ListBox1.SelectedItem.ToString.Contains("http://www.proxynova.com/proxy-server-list/") Then
            reg = New Regex("<span class=""row_proxy_ip"">.*") '
            SplitVar = 1
            useport = True
            If ListBox1.SelectedItem.ToString.Contains("/port-80/") Then
                portval = "80"
            ElseIf ListBox1.SelectedItem.ToString.Contains("/port-8080/") Then
                portval = "8080"
            End If

        ElseIf ListBox1.SelectedItem.ToString.Contains("http://proxy-list.org/") Then


        ElseIf ListBox1.SelectedItem.ToString.Contains("http://proxylist.hidemyass.com/") Then
            reg = New Regex("<li class=""proxy"">.*</li>")
            SplitVar = 1
            For Each s As String() In Regex.Matches(New WebClient().DownloadString("http://proxylist.hidemyass.com/"), "(?:<td class=""leftborder timestamp""(?s).+?<style>)((?s).+?)\s*<td>\s+(\d{2,5})</td>").Cast(Of Match)().[Select](Function(m) New String() {m.Groups(1).Value, m.Groups(2).Value})
                Regex.Matches(s(0), "\.([^\{]+)\{([^\}]+)\}").Cast(Of Match)().ToList().ForEach(Function(m) InlineAssignHelper(s(0), s(0).Replace(String.Format("class=""{0}""", m.Groups(1).Value), String.Format("style=""{0}""", m.Groups(2).Value))))
                ListBox2.Items.Add(String.Concat(Regex.Matches(Regex.Replace(Regex.Replace(s(0), "<(span|div) style=""display:none"">[\d\.]+</\1>", String.Empty).Remove(0, s(0).IndexOf("/style>")), "class=""\d+""", String.Empty), "[\d\.]+").Cast(Of Match)().[Select](Function(m) m.Value)) & ":" & s(1))
            Next
            For Each s As String() In Regex.Matches(New WebClient().DownloadString("http://proxylist.hidemyass.com/2"), "(?:<td class=""leftborder timestamp""(?s).+?<style>)((?s).+?)\s*<td>\s+(\d{2,5})</td>").Cast(Of Match)().[Select](Function(m) New String() {m.Groups(1).Value, m.Groups(2).Value})
                Regex.Matches(s(0), "\.([^\{]+)\{([^\}]+)\}").Cast(Of Match)().ToList().ForEach(Function(m) InlineAssignHelper(s(0), s(0).Replace(String.Format("class=""{0}""", m.Groups(1).Value), String.Format("style=""{0}""", m.Groups(2).Value))))
                ListBox2.Items.Add(String.Concat(Regex.Matches(Regex.Replace(Regex.Replace(s(0), "<(span|div) style=""display:none"">[\d\.]+</\1>", String.Empty).Remove(0, s(0).IndexOf("/style>")), "class=""\d+""", String.Empty), "[\d\.]+").Cast(Of Match)().[Select](Function(m) m.Value)) & ":" & s(1))
            Next
            For Each s As String() In Regex.Matches(New WebClient().DownloadString("http://proxylist.hidemyass.com/3"), "(?:<td class=""leftborder timestamp""(?s).+?<style>)((?s).+?)\s*<td>\s+(\d{2,5})</td>").Cast(Of Match)().[Select](Function(m) New String() {m.Groups(1).Value, m.Groups(2).Value})
                Regex.Matches(s(0), "\.([^\{]+)\{([^\}]+)\}").Cast(Of Match)().ToList().ForEach(Function(m) InlineAssignHelper(s(0), s(0).Replace(String.Format("class=""{0}""", m.Groups(1).Value), String.Format("style=""{0}""", m.Groups(2).Value))))
                ListBox2.Items.Add(String.Concat(Regex.Matches(Regex.Replace(Regex.Replace(s(0), "<(span|div) style=""display:none"">[\d\.]+</\1>", String.Empty).Remove(0, s(0).IndexOf("/style>")), "class=""\d+""", String.Empty), "[\d\.]+").Cast(Of Match)().[Select](Function(m) m.Value)) & ":" & s(1))
            Next
            For Each s As String() In Regex.Matches(New WebClient().DownloadString("http://proxylist.hidemyass.com/4"), "(?:<td class=""leftborder timestamp""(?s).+?<style>)((?s).+?)\s*<td>\s+(\d{2,5})</td>").Cast(Of Match)().[Select](Function(m) New String() {m.Groups(1).Value, m.Groups(2).Value})
                Regex.Matches(s(0), "\.([^\{]+)\{([^\}]+)\}").Cast(Of Match)().ToList().ForEach(Function(m) InlineAssignHelper(s(0), s(0).Replace(String.Format("class=""{0}""", m.Groups(1).Value), String.Format("style=""{0}""", m.Groups(2).Value))))
                ListBox2.Items.Add(String.Concat(Regex.Matches(Regex.Replace(Regex.Replace(s(0), "<(span|div) style=""display:none"">[\d\.]+</\1>", String.Empty).Remove(0, s(0).IndexOf("/style>")), "class=""\d+""", String.Empty), "[\d\.]+").Cast(Of Match)().[Select](Function(m) m.Value)) & ":" & s(1))
            Next
            For Each s As String() In Regex.Matches(New WebClient().DownloadString("http://proxylist.hidemyass.com/5"), "(?:<td class=""leftborder timestamp""(?s).+?<style>)((?s).+?)\s*<td>\s+(\d{2,5})</td>").Cast(Of Match)().[Select](Function(m) New String() {m.Groups(1).Value, m.Groups(2).Value})
                Regex.Matches(s(0), "\.([^\{]+)\{([^\}]+)\}").Cast(Of Match)().ToList().ForEach(Function(m) InlineAssignHelper(s(0), s(0).Replace(String.Format("class=""{0}""", m.Groups(1).Value), String.Format("style=""{0}""", m.Groups(2).Value))))
                ListBox2.Items.Add(String.Concat(Regex.Matches(Regex.Replace(Regex.Replace(s(0), "<(span|div) style=""display:none"">[\d\.]+</\1>", String.Empty).Remove(0, s(0).IndexOf("/style>")), "class=""\d+""", String.Empty), "[\d\.]+").Cast(Of Match)().[Select](Function(m) m.Value)) & ":" & s(1))
            Next
            For Each s As String() In Regex.Matches(New WebClient().DownloadString("http://proxylist.hidemyass.com/6"), "(?:<td class=""leftborder timestamp""(?s).+?<style>)((?s).+?)\s*<td>\s+(\d{2,5})</td>").Cast(Of Match)().[Select](Function(m) New String() {m.Groups(1).Value, m.Groups(2).Value})
                Regex.Matches(s(0), "\.([^\{]+)\{([^\}]+)\}").Cast(Of Match)().ToList().ForEach(Function(m) InlineAssignHelper(s(0), s(0).Replace(String.Format("class=""{0}""", m.Groups(1).Value), String.Format("style=""{0}""", m.Groups(2).Value))))
                ListBox2.Items.Add(String.Concat(Regex.Matches(Regex.Replace(Regex.Replace(s(0), "<(span|div) style=""display:none"">[\d\.]+</\1>", String.Empty).Remove(0, s(0).IndexOf("/style>")), "class=""\d+""", String.Empty), "[\d\.]+").Cast(Of Match)().[Select](Function(m) m.Value)) & ":" & s(1))
            Next
            For Each s As String() In Regex.Matches(New WebClient().DownloadString("http://proxylist.hidemyass.com/7"), "(?:<td class=""leftborder timestamp""(?s).+?<style>)((?s).+?)\s*<td>\s+(\d{2,5})</td>").Cast(Of Match)().[Select](Function(m) New String() {m.Groups(1).Value, m.Groups(2).Value})
                Regex.Matches(s(0), "\.([^\{]+)\{([^\}]+)\}").Cast(Of Match)().ToList().ForEach(Function(m) InlineAssignHelper(s(0), s(0).Replace(String.Format("class=""{0}""", m.Groups(1).Value), String.Format("style=""{0}""", m.Groups(2).Value))))
                ListBox2.Items.Add(String.Concat(Regex.Matches(Regex.Replace(Regex.Replace(s(0), "<(span|div) style=""display:none"">[\d\.]+</\1>", String.Empty).Remove(0, s(0).IndexOf("/style>")), "class=""\d+""", String.Empty), "[\d\.]+").Cast(Of Match)().[Select](Function(m) m.Value)) & ":" & s(1))
            Next
            For Each s As String() In Regex.Matches(New WebClient().DownloadString("http://proxylist.hidemyass.com/8"), "(?:<td class=""leftborder timestamp""(?s).+?<style>)((?s).+?)\s*<td>\s+(\d{2,5})</td>").Cast(Of Match)().[Select](Function(m) New String() {m.Groups(1).Value, m.Groups(2).Value})
                Regex.Matches(s(0), "\.([^\{]+)\{([^\}]+)\}").Cast(Of Match)().ToList().ForEach(Function(m) InlineAssignHelper(s(0), s(0).Replace(String.Format("class=""{0}""", m.Groups(1).Value), String.Format("style=""{0}""", m.Groups(2).Value))))
                ListBox2.Items.Add(String.Concat(Regex.Matches(Regex.Replace(Regex.Replace(s(0), "<(span|div) style=""display:none"">[\d\.]+</\1>", String.Empty).Remove(0, s(0).IndexOf("/style>")), "class=""\d+""", String.Empty), "[\d\.]+").Cast(Of Match)().[Select](Function(m) m.Value)) & ":" & s(1))
            Next
            For Each s As String() In Regex.Matches(New WebClient().DownloadString("http://proxylist.hidemyass.com/9"), "(?:<td class=""leftborder timestamp""(?s).+?<style>)((?s).+?)\s*<td>\s+(\d{2,5})</td>").Cast(Of Match)().[Select](Function(m) New String() {m.Groups(1).Value, m.Groups(2).Value})
                Regex.Matches(s(0), "\.([^\{]+)\{([^\}]+)\}").Cast(Of Match)().ToList().ForEach(Function(m) InlineAssignHelper(s(0), s(0).Replace(String.Format("class=""{0}""", m.Groups(1).Value), String.Format("style=""{0}""", m.Groups(2).Value))))
                ListBox2.Items.Add(String.Concat(Regex.Matches(Regex.Replace(Regex.Replace(s(0), "<(span|div) style=""display:none"">[\d\.]+</\1>", String.Empty).Remove(0, s(0).IndexOf("/style>")), "class=""\d+""", String.Empty), "[\d\.]+").Cast(Of Match)().[Select](Function(m) m.Value)) & ":" & s(1))
            Next



        ElseIf ListBox1.SelectedItem.ToString.Contains("http://www.gatherproxy.com/") Then
            reg = New Regex("PROXY_IP"":"".*")
        Else
            reg = New Regex("<tr><td>.*</td><td>.*</td>")
            SplitVar = 2
            Port = True
        End If



        Dim Matches As MatchCollection = reg.Matches(UseSource)




        For Each ProxyString As Match In Matches
            Dim x As String = ProxyString.Value.Split(">").GetValue(SplitVar)
            Dim z As String = x.Split("<").GetValue(0)
            If Port Then
                Dim o As String = ProxyString.Value.Split(">").GetValue(4)
                Dim d As String = o.Split("<").GetValue(0)
                z = z & ":" & d
            End If
            If useport Then
                z = z.Replace("		  ", "")
                z = z & ":" & portval
            End If
            If IsNumeric(z(0)) Then
                ListBox2.Items.Add(z)
            End If
        Next




        If Not ListBox1.SelectedIndex = ListBox1.Items.Count - 1 Then
            ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
            CheckRegExp()
            Exit Sub
        Else
            MessageBox.Show("Done!", "Alert")
        End If

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If VTabControl1.SelectedIndex = 1 Then
            ListBox1.Items.Clear()
            ListBox2.Items.Clear()
            If VCheckBox1.Checked = True Then
                ListBox1.Items.Add("http://www.socks-proxy.net/")
            End If


            If VCheckBox2.Checked = True Then
                ListBox1.Items.Add("http://free-proxy-list.net/anonymous-proxy.html")
            End If


            If VCheckBox3.Checked = True Then
                ListBox1.Items.Add("http://www.us-proxy.org/")
            End If


            If VCheckBox4.Checked = True Then
                ListBox1.Items.Add("http://www.proxynova.com/proxy-server-list/port-8080/")
                ListBox1.Items.Add("http://www.proxynova.com/proxy-server-list/port-80/")
            End If


            If VCheckBox5.Checked = True Then
                ListBox1.Items.Add("http://www.sslproxies.org/")
            End If


            If VCheckBox6.Checked = True Then
                For x As Integer = 1 To 10
                    ListBox1.Items.Add("http://proxy-list.org/english/index.php?p=" & x)
                Next
            End If


            If VCheckBox7.Checked = True Then
                ListBox1.Items.Add("http://www.google-proxy.net/")
            End If

            If VCheckBox8.Checked = True Then
                ListBox1.Items.Add("http://proxylist.hidemyass.com/")
            End If

            Try
                ListBox1.SelectedIndex = 0
                CheckRegExp()
            Catch ex As Exception
                MessageBox.Show("Do you have any proxies selected?", "Error")
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Using FD As New SaveFileDialog()
            FD.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*" '
            If FD.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim myFile As String = FD.FileName
                Dim myWriter As New IO.StreamWriter(myFile)
                For i As Integer = 0 To ListBox2.Items.Count - 1 '
                    myWriter.WriteLine(ListBox2.Items.Item(i)) '
                Next
                myWriter.Close()
            End If
        End Using
    End Sub


    Public Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim fo As New OpenFileDialog
        fo.RestoreDirectory = True
        fo.Multiselect = False
        fo.Filter = "txt files (*.txt)|*.txt"
        fo.FilterIndex = 1
        fo.ShowDialog()
        If (Not fo.FileName = Nothing) Then
            Dim proxies As New List(Of String)
            Dim myfile As String = fo.FileName
            Dim reader As New System.IO.StreamReader(myfile)
            'ListBox3.Text = (reader.ReadToEnd)
            Do Until reader.EndOfStream
                ListBox3.Items.Add(reader.ReadLine)
            Loop
            Using sr As New StreamReader(fo.FileName)
                While sr.Peek <> -1
                    proxies.Add(sr.ReadLine())
                    Label5.Text = myfile
                End While
            End Using
        End If
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Label5.Text = ("Label5") Then
            MessageBox.Show("Open a file first")
        End If
        If Label5.Text <> "Label5" Then
            Dim proxies As New List(Of String)
            Using sr As New StreamReader(Label5.Text)
                While sr.Peek <> -1
                    proxies.Add(sr.ReadLine())
                End While
            End Using
            Dim myProxy As WebProxy

            For Each proxy As String In proxies
                Try
                    myProxy = New WebProxy(proxy)
                    Dim r As HttpWebRequest = HttpWebRequest.Create("http://www.google.com/")
                    r.UserAgent = "Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/29.0.1547.2 Safari/537.36"
                    r.Timeout = 3000
                    r.Proxy = myProxy
                    Dim re As HttpWebResponse = r.GetResponse()
                    ListBox4.Items.Add(proxy)
                Catch ex As Exception
                    ListBox5.Items.Add(proxy)
                End Try
            Next
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (ListBox4.Items.Count > 0) Then
            Dim fs As New SaveFileDialog
            fs.RestoreDirectory = True
            fs.Filter = "txt files (*.txt)|*.txt"
            fs.FilterIndex = 1
            fs.ShowDialog()
            If Not (fs.FileName = Nothing) Then
                Using sw As New StreamWriter(fs.FileName)
                    For Each line As String In ListBox4.Items
                        sw.WriteLine(line)
                    Next
                End Using
            End If
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://leakforums.org/user-448581")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Process.Start("https://leakforums.org/user-448581")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ListBox2.Items.Clear()
        ListBox1.Items.Clear()
    End Sub
End Class
