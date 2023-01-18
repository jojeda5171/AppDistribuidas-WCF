
package clientews;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElementRef;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Clase Java para anonymous complex type.
 * 
 * <p>El siguiente fragmento de esquema especifica el contenido que se espera que haya en esta clase.
 * 
 * <pre>
 * &lt;complexType>
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="listarClienteResult" type="{http://schemas.datacontract.org/2004/07/UTA.FISEI.Prestamos.Dominio}ArrayOfCliente" minOccurs="0"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "", propOrder = {
    "listarClienteResult"
})
@XmlRootElement(name = "listarClienteResponse")
public class ListarClienteResponse {

    @XmlElementRef(name = "listarClienteResult", namespace = "http://tempuri.org/", type = JAXBElement.class, required = false)
    protected JAXBElement<ArrayOfCliente> listarClienteResult;

    /**
     * Obtiene el valor de la propiedad listarClienteResult.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link ArrayOfCliente }{@code >}
     *     
     */
    public JAXBElement<ArrayOfCliente> getListarClienteResult() {
        return listarClienteResult;
    }

    /**
     * Define el valor de la propiedad listarClienteResult.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link ArrayOfCliente }{@code >}
     *     
     */
    public void setListarClienteResult(JAXBElement<ArrayOfCliente> value) {
        this.listarClienteResult = value;
    }

}
