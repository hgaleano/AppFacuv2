@ModelType IEnumerable(Of Curso)
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
</head>
<body>
    <h1>Carga de Calificaciones</h1>
    Curso:
    <select id="cboCurso" onchange="RecuperarAlumnos()">
        @For Each item In Model
        @<option value="@item.CodCurso">@item.Descripcion</Option>
        Next
    </select>

    <div id="DivAlumnos">

    </div>

    <script src="~/scripts/js/jquery-3.6.0.min.js"></script>
    <script src="~/scripts/js/facu.js"></script>
</body>
</html>
