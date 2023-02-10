//JavaScript Code

var lista =new Array('1.jpg','2.jpg','3.jpg');
var contador=0;
var tiempo=0;
var tempor= null;

function cambio(sen) {
	contador+=sen;
	 if (contador==lista.length) {
	  contador= lista.length-1;
	 }else if(contador<0){
      contador=0;
	}
	document.images.centro.src = lista(contador)
    window.status="Imagen numero"+contador;
  } 
function reset() {
	contador=0;
	fin=false;
	document.images.centro.src=lista[0];
  }
function automat(seg) {
	tiempo=parseInt(seg);
	reset();
	window.status="Pase Automatico";
	 if(NaN(tiempo) || tiempo <= 0 ){
		alert("error en el tiempo")
	 }else{
		tempor=setTimeout("pasar()",tiempo)
	}
  }
function parar(){
    clearTimeout(tempor);
  }
function pasar(){
	cambio(1);
	if (contador<lista.length-1) {
		tempor=setTimeout("pasar()",tiempo)
	}
}


