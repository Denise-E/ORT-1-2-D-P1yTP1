package TP3_Ej12;

import java.util.ArrayList;

public class Dia {
	private final int MAX_CUPOS = 50;
	private int cuposDados;
	private String fecha;
	private boolean habil;
	private ArrayList<Persona> personas;
	
	
	public Dia(String fecha) {
		super();
		this.setCuposDados(0);
		this.setFecha(fecha);
		this.setHabil(false);
		this.personas = new ArrayList<>();
	}
	
	
	public Dia(String fecha, boolean habil) {
		this(fecha);
		this.setHabil(habil);
	}
	
	public double promedioEdadPersonasSinOS() {
		int acumEdades = 0;
		int cont = 0;
		int promedioEdades = 0;
		
		for (Persona p : this.personas) {
			
			if(!(p instanceof PersonaConObraSocial)) {
				cont++;
				acumEdades += p.obtenerEdad();
			}
		}
		
		if(cont != 0) {
			promedioEdades = acumEdades / cont;
		}
		
		return promedioEdades;
	}
	
	
	private void setCuposDados(int cuposDados) {
		this.cuposDados = cuposDados;
	}
	private void setFecha(String fecha) {
		this.fecha = fecha;
	}
	private void setHabil(boolean habil) {
		this.habil = habil;
	}


	public double revisarPersonasFuera() {
		/*
		 * Comprobar si alcanzan la cantidad de test para cubrir a todos los inscriptos.
II. Notificar a aquellas personas que queden afuera.
Retorna el porcentaje de personas que quedaron afuera sobre el total (para todos los días).
		 */
		
		int i = 0;
		int cantFuera = 0;
		double promedio = 0;
		
		for (Persona p : this.personas) {
			i++;
			
			if(i > this.MAX_CUPOS) {
				cantFuera++;
				p.mostrarMensaje("NO HAY MAS CUPOS PARA ESE DIA.");
			}
		}
		
		if(cantFuera != 0) {
			promedio = cantFuera / i;
		}
		
		return promedio;
	}


	public int calcularCantPrioritarios() {
		int acum = 0;
		
		for (Persona p : this.personas) {
			if(!(p instanceof PersonaConObraSocial) || p.esPriorizable() == 1) {
				acum++;
			}
		}
		
		return acum;
	}


	public void agregarPersona(Persona p) {
		this.personas.add(p);
		
	}


	@Override
	public String toString() {
		return "Dia [MAX_CUPOS=" + MAX_CUPOS + ", cuposDados=" + cuposDados + ", fecha=" + fecha + ", habil=" + habil
				+ ", personas=" + personas + "]";
	}
	
	
}
