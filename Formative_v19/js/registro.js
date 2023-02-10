
// JavaScript Document

function validarForm(form){
	var nombre= form.nombre;
	if(nombre.value == ""){
	  alert("INGRESE SUS NOMBRES");
	  nombre.focus();
	  nombre.select();
	  return false;
	}
	var apellido=form.apellido;
	if(apellido.value == ""){
	  alert("INGRESE SUS APELLIDOS");
	  nombre.focus();
	  nombre.select();
	  return false;
	}
	
}