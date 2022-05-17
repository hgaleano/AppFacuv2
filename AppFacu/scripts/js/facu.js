function RecuperarAlumnos() {
    var curso_seleccionado = 0;
    curso_seleccionado = document.getElementById("cboCurso").value;
    console.log("Curso ID seleccionado:" + curso_seleccionado);

    $.get("Home/ListaAlumnosPorCursoID", 'id=' + curso_seleccionado, function (data){
        console.log(data);

        var contenido = "";
        contenido += "<table border='1'>";
        contenido += "<tr>";
        contenido += "<th>Nombre</th>"
        contenido += "<th></th>"
        contenido += "</tr>";

        var fila;
        for (var i = 0; i < data.length; i++) {
            fila = data[i];
            contenido += "<tr>";
            contenido += "<td>";
            contenido += fila.NombreApellido;
            contenido += "</td>";
            contenido += "<td>";
            contenido += "<a href='Home/Calificar/?CodCurso="+fila.CodCurso+"&CodAlumno="+fila.CodAlumno+"'>Seleccionar</a>";
            contenido += "</td>";
            contenido += "</tr>";
        }

        contenido += "</table>";
        document.getElementById("DivAlumnos").innerHTML = contenido;
    })
   
}