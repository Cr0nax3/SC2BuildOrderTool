Imports SC2BuildOrderTool

Public Class Building
    Inherits General



    Public Sub New(name_new As String, breed_new As String, crystals_new As Short, gas_new As Short, duration_new As Short, hitpoints_new As Short, requirements_new As Object, task_new As Task)
        MyBase.New(name_new, breed_new, crystals_new, gas_new, duration_new, hitpoints_new, requirements_new, task_new)
    End Sub
End Class
