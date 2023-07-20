package ejemplo1calidad;

/**
 *
 * @author josel
 */
public class Curso {
    String nombreCurso;
    int cantHora;

    public Curso(String nombreCurso, int cantHora) {
        this.nombreCurso = nombreCurso;
        this.cantHora = cantHora;
    }
    
    public void reporteInscritos(){
        System.out.println("Reporte de inscritos");
    }
    
}
