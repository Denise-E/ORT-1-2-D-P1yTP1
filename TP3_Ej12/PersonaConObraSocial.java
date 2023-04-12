package TP3_Ej12;

public class PersonaConObraSocial extends Persona {
	private String nombreOS, numAfiliado;

	public PersonaConObraSocial(String dni, String nombre, String apellido, int edad, MotivoTest motivo, String nombreOS, String numAfiliado) {
		super(dni, nombre, apellido, edad, motivo);
		this.setNombreOS(nombreOS);
		this.setNumAfiliado(numAfiliado);
	}

	private void setNombreOS(String nombreOS) {
		this.nombreOS = nombreOS;
	}

	private void setNumAfiliado(String numAfiliado) {
		this.numAfiliado = numAfiliado;
	}

	
}
