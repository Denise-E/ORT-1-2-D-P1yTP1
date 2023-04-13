package TP3_Ej12;

public class Test {

	public static void main(String[] args) {
		Centro c = new Centro();
		Dia d = new Dia("Lunes");
		Dia d2 = new Dia("Martes");
		Persona p1 = new Persona("11111111", "Denise", "EEEE", 21, MotivoTest.CONTACTO_ESTRECHO);
		Persona p2 = new PersonaConObraSocial("22222222", "Jorge", "FFFF", 40, MotivoTest.CONTACTO_ESTRECHO, "Swiss", "1311234444");
		Persona p3 = new Persona("33333333", "Fulano", "RRR", 23, MotivoTest.REPETICION_POR_ERROR);
		
		c.agregarDia(d);
		c.agregarDia(d2);
		
		d.agregarPersona(p1);
		d.agregarPersona(p2);
		d.agregarPersona(p3);
		d2.agregarPersona(p2);
		d2.agregarPersona(p1);
		d2.agregarPersona(p1);
		d2.agregarPersona(p3);
		
		c.revisar();
		c.mostrarDiaConMasPrioritarios(); 
		System.out.println(d.promedioEdadPersonasSinOS()); 
		
		

	}

}
