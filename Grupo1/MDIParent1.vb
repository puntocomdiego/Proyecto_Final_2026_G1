Imports System.Windows.Forms

Public Class MDIParent1

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            Dim FileName = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            Dim FileName = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub



    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm In MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblInformacion.Text = "Usuario: " & usuario & " | " & "Rol: " & rol
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Dim f As New fmr_usurios
        f.MdiParent = Me
        f.Show()

    End Sub

    Private Sub CategoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriasToolStripMenuItem.Click
        Dim f As New frm_categorias
        f.MdiParent = Me
        f.Show()

    End Sub

    Private Sub JuegosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JuegosToolStripMenuItem.Click
        Dim f As New frm_Juegos
        f.MdiParent = Me
        f.Show()

    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        Dim f As New Ventas
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ConsultasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultasToolStripMenuItem.Click
        Dim f As New FrmConsultas
        f.MdiParent = Me
        f.Show()
    End Sub

    'Private Sub btnsalir_Click(sender As Object, e As EventArgs)
    '    Dim i = MessageBox.Show("¿Desea salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    '    If i = DialogResult.Yes Then
    '        Close()
    '    End If
    'End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim i = MessageBox.Show("¿Desea salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If i = DialogResult.Yes Then
            CerrarTodos()
            Me.Close()
        End If
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        Dim i = MessageBox.Show("¿Desea cerrar sesión?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If i = DialogResult.Yes Then
            rol = Nothing
            usuario = Nothing
            CerrarTodos()
            Login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub CerrarTodos()
        For Each ChildForm In MdiChildren
            ChildForm.Close()
        Next
    End Sub

End Class
