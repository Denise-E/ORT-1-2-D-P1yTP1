package TP3_Ej12;

public class Persona implements Priorizable, Notificable{
	private String dni, nombre, apellido;
	private int edad;
	private MotivoTest motivo;
	
	
	
	public Persona(String dni, String nombre, String apellido, int edad, MotivoTest motivo) {
		this.setDni(dni);
		this.setNombre(nombre);
		this.setApellido(apellido);
		this.setEdad(edad);
		this.setMotivo(motivo);
	}
	
	@Override
	public void mostrarMensaje(String m) {
		// TODO Auto-generated method stub
		
	}
	@Override
	public boolean esPriorizable() {
		/*
		 * debe devolver un valor entero 1 indicando si tiene prioridad o 2 si no tiene. Una
persona tendrá prioridad (devolverá 1) si cumple con alguna de las siguientes reglas:
o No tiene obra social.
o Su edad es mayor o igual a 60
o Tuvo contacto estrecho.
		 */
		return false;
	}
	
	private void setDni(String dni) {
		this.dni = dni;
	}
	private void setNombre(String nombre) {
		this.nombre = nombre;
	}
	private void setApellido(String apellido) {
		this.apellido = apellido;
	}
	private void setEdad(int edad) {
		this.edad = edad;
	}
	private void setMotivo(MotivoTest motivo) {
		this.motivo = motivo;
	}

	public int obtenerEdad() {
		return this.edad;
	}
	
	
}
