Public Class General
    Private name As String
    Private breed As String
    Private crystals As Int16
    Private gas As Int16
    Private duration As Int16
    Private hitpoints As Int16
    Private requirements As Object
    Private task As Task






    Sub New(ByVal name_new As String, ByVal breed_new As String, ByVal crystals_new As Int16, ByVal gas_new As Int16, ByVal duration_new As Int16, ByVal hitpoints_new As Int16, ByVal requirements_new As Object, ByVal task_new As Task)
        Try
            name = name_new
            breed = breed_new
            crystals = crystals_new
            gas = gas_new
            duration = duration_new
            hitpoints = hitpoints_new
            requirements = requirements_new
            task = task_new
        Catch ex As Exception

        End Try

    End Sub

    'Getter

    Public Function getCrystals() As Int16
        Return crystals
    End Function

    Public Function getGas() As Int16
        Return gas
    End Function

    Public Function getDuration() As Int16
        Return duration
    End Function

    Public Function getHitpoints() As Int16
        Return hitpoints
    End Function

    Public Function getRequirements() As Object
        Return requirements
    End Function

    Public Function getTask() As Task
        Return task
    End Function

End Class
