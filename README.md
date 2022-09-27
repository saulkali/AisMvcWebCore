# AisMvcWebCore
mini sitio web desarrollado con asp core mvc

# funciones 
1. tiene solo una pantalla donde se ingresa el numero factorial, tanto en ajax como del lado del cliente
2. el mismo campo de texto añade valores a un array

# Como instalarlo 
dentro de visual studio nos da la opcion de importar un proyecto desde git, basta con solo poner esta direccion y visual studio instalaria todo de manera automatica

# bugs 
1. al calcular el factorial del lado del servidor no redirecciona correctamente, lo cual se podria solucionar buscando un poco en MapControllerRouter
2. la api ordena los datos mas no, logre conectar el consumo de esto, se puede solucionar mandando el array que ya se encuentra creado al cuerpo data de ajax para enviar el array el servidor retorna el mensaje de manera automatica ya con la lista ordenada.
