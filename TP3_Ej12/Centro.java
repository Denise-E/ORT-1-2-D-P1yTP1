package TP3_Ej12;

import java.util.ArrayList;

public class Centro {
	private ArrayList<Dia> dias;
	
	public Centro() {
		this.dias = new ArrayList<>();
	}
	
	public int revisar() {
		/*
		 * Comprobar si alcanzan la cantidad de test para cubrir a todos los inscriptos.
II. Notificar a aquellas personas que queden afuera.
Retorna el porcentaje de personas que quedaron afuera sobre el total (para todos los días).
		 */
		int acum = 0, cont = 0, porcentaje = 0;
		
		for (Dia d : this.dias) {
			acum += d.revisarPersonasFuera();
			cont++;
		}
		
		if(cont != 0) {
			porcentaje = acum / cont;
		}
		
		return porcentaje;
	}
	
	public void mostrarDiaConMasPrioritarios() {
		int max = -1;
		Dia diaMax = null;
		
		for (Dia d : this.dias) {
			int cantPrioritarios = d.calcularCantPrioritarios();
			
			
			if(cantPrioritarios > max) {
				max = cantPrioritarios;
				diaMax = d;
			}
		}
		
		System.out.println("El dia con mas prioritarios es el: " + diaMax);
	}

	public void agregarDia(Dia d) {
		this.dias.add(d);
	}
}
