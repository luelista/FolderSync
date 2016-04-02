Imports System.Xml.Serialization

<Serializable()>
Public Class ArchiveInfoFile

  Public Property ArchiveName As String
  Public Property UserName As String
  Public Property Comment As String

  <XmlArrayItem("name")>
  Public Property FileList As List(Of String)

  Public Shared Function Read(fn As String) As ArchiveInfoFile
    Dim serializer As New XmlSerializer(GetType(ArchiveInfoFile), New XmlRootAttribute("ArchiveInfo"))
    Read = Nothing
    Using file = System.IO.File.OpenRead(fn)
      Read = DirectCast(serializer.Deserialize(file), ArchiveInfoFile)
    End Using
  End Function

  Public Sub Write(fn As String)
    Dim serializer As New XmlSerializer(GetType(ArchiveInfoFile), New XmlRootAttribute("ArchiveInfo"))
    Using file As System.IO.FileStream = System.IO.File.Open(fn, IO.FileMode.OpenOrCreate, IO.FileAccess.Write)
      serializer.Serialize(file, Me)
    End Using
  End Sub

End Class
