/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javaapplication2;

/**
 *
 * @author josel
 */
import clientews.ListarCliente;
import clientews.ObtenerCliente;
import clientews.ListarClienteResponse;
import clientews.Cliente;
import clientews.ClienteService;

import javax.xml.bind.JAXBElement;
public class JavaApplication2 {

    /**
     * @param args the command line arguments
     */
    
    
    public static void main(String[] args) {
        // TODO code application logic here
        
        ClienteService lista=new ClienteService();
        
        
        //System.out.println(lista.getBasicHttpBindingIClienteService().listarCliente().getCliente().get(1).getIdCliente().toString());
        System.out.println(lista.getBasicHttpBindingIClienteService().obtenerCliente("1850435171").getApellidoPaterno().getValue());
        
    }
    
}
