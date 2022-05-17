Imports System.Web.Mvc

Namespace Controllers
    Public Class HomeController
        Inherits Controller
        Dim db As FacuEntities = New FacuEntities

        ' GET: Home
        Function Index() As ActionResult
            Dim ListCurso As New List(Of Curso)
            ListCurso = db.Curso.ToList
            Return View(ListCurso)
        End Function
        Function ListaAlumnosPorCursoID(id As Integer) As JsonResult
            Dim ListAlumnos = From curso_alumno In db.CursoAlumno
                              Join alumno In db.Alumno
                                  On curso_alumno.CodAlumno Equals alumno.CodAlumno
                              Where curso_alumno.CodCurso = id
                              Select New With {
                                  curso_alumno.CodCurso,
                                  curso_alumno.CodAlumno,
                                  alumno.NombreApellido
                                  }

            Return New JsonResult With {
                .Data = ListAlumnos,
                .JsonRequestBehavior = JsonRequestBehavior.AllowGet
            }
        End Function

        Function Calificar(CodCurso As Integer, CodAlumno As Integer) As ActionResult
            Return View()
        End Function
    End Class
End Namespace