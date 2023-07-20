package ejemplo1calidad;

import java.util.Date;

/**
 *
 * @author josel
 */
public class Estudiante {

    String nombreEstudiante, direccion, cedula;
    Date fechaNecimiento;

    public Estudiante(String nombreEstudiante, String direccion, String cedula, Date fechaNecimiento) {
        this.nombreEstudiante = nombreEstudiante;
        this.direccion = direccion;
        this.cedula = cedula;
        this.fechaNecimiento = fechaNecimiento;
    }

    public double promedioAcademico() {
        return 0;
    }

    public int edad() {
        return 0;
    }

}
