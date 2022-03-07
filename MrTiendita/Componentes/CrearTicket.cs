using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.InteropServices;

/// <summary>Clases que crean tickets validos para imprimir.</summary>
namespace CrearTicketVenta
{
    /// <summary> Esta es la clase para crear el ticket de venta. Crearemos varios métodos aquí. </summary>
    public class CrearTicket
    {
        /// <summary> Creamos un objeto de la clase StringBuilder, en este objeto agregaremos las lineas del ticket </summary>
        StringBuilder linea = new StringBuilder();

        /// <summary> Creamos una variable para almacenar el numero maximo de caracteres que permitiremos en el ticket. </summary>
        private readonly int maxCar = 40;
        /// <summary> The cortar </summary>
        private int cortar;

        /// <summary> Gets or sets de linea. </summary>
        /// <value> The linea. </value>
        public StringBuilder Linea { get => linea; set => linea = value; }

        /// <summary> Creamos el primer metodo, este dibujara lineas guion.. </summary>
        /// <returns>Devolvemos la lineaGuion.</returns>
        public string LineasGuion()
        {
            string lineasGuion = "";
            for (int i = 0; i < maxCar; i++)
            {
                lineasGuion += "-";//Agregara un guio hasta llegar la numero maximo de caracteres.
            }
            return Linea.AppendLine(lineasGuion).ToString();
        }

        /// <summary>Metodo para dibujar una linea con asteriscos. </summary>
        /// <returns>Devolvemos la linea con asteriscos</returns>
        public string LineasAsteriscos()
        {
            string lineasAsterisco = "";
            for (int i = 0; i < maxCar; i++)
            {
                lineasAsterisco += "*";//Agregara un asterisco hasta llegar la numero maximo de caracteres.
            }
            return Linea.AppendLine(lineasAsterisco).ToString();
        }

        /// <summary> Realizamos el mismo procedimiento para dibujar una lineas con el signo igual. </summary>
        /// <returns>Devolvemos la lienas con iguales.</returns>
        public string LineasIgual()
        {
            string lineasIgual = "";
            for (int i = 0; i < maxCar; i++)
            {
                lineasIgual += "=";//Agregara un igual hasta llegar la numero maximo de caracteres.
            }
            return Linea.AppendLine(lineasIgual).ToString();
        }

        /// <summary> Creamos el encabezado para los articulos </summary>
        public void EncabezadoVenta()
        {
            //Escribimos los espacios para mostrar el articulo. En total tienen que ser 40 caracteres
            Linea.AppendLine("ARTÍCULO            |CANT|PRECIO|IMPORTE");
        }

        /// <summary> Creamos un metodo para poner el texto a la izquierda. </summary>
        /// <param name="texto">The texto.</param>
        public void TextoIzquierda(string texto)
        {
            //Si la longitud del texto es mayor al numero maximo de caracteres permitidos, realizar el siguiente procedimiento.
            if (texto.Length > maxCar)
            {
                int caracterActual = 0;//Nos indicara en que caracter se quedo al bajar el texto a la siguiente linea
                for (int longitudTexto = texto.Length; longitudTexto > maxCar; longitudTexto -= maxCar)
                {
                    //Agregamos los fragmentos que salgan del texto
                    Linea.AppendLine(texto.Substring(caracterActual, maxCar));
                    caracterActual += maxCar;
                }
                //agregamos el fragmento restante
                Linea.AppendLine(texto.Substring(caracterActual, texto.Length - caracterActual));
            }
            else
            {
                //Si no es mayor solo agregarlo.
                Linea.AppendLine(texto);
            }
        }

        /// <summary> Creamos un metodo para poner texto a la derecha.</summary>
        /// <param name="texto">The texto.</param>
        public void TextoDerecha(string texto)
        {
            //Si la longitud del texto es mayor al numero maximo de caracteres permitidos, realizar el siguiente procedimiento.
            if (texto.Length > maxCar)
            {
                int caracterActual = 0;//Nos indicara en que caracter se quedo al bajar el texto a la siguiente linea
                for (int longitudTexto = texto.Length; longitudTexto > maxCar; longitudTexto -= maxCar)
                {
                    //Agregamos los fragmentos que salgan del texto
                    Linea.AppendLine(texto.Substring(caracterActual, maxCar));
                    caracterActual += maxCar;
                }
                //Variable para poner espacios restntes
                string espacios = "";
                //Obtenemos la longitud del texto restante.
                for (int i = 0; i < (maxCar - texto.Substring(caracterActual, texto.Length - caracterActual).Length); i++)
                {
                    espacios += " ";//Agrega espacios para alinear a la derecha
                }

                //agregamos el fragmento restante, agregamos antes del texto los espacios
                Linea.AppendLine(espacios + texto.Substring(caracterActual, texto.Length - caracterActual));
            }
            else
            {
                string espacios = "";
                //Obtenemos la longitud del texto restante.
                for (int i = 0; i < (maxCar - texto.Length); i++)
                {
                    espacios += " ";//Agrega espacios para alinear a la derecha
                }
                //Si no es mayor solo agregarlo.
                Linea.AppendLine(espacios + texto);
            }
        }

        /// <summary> Metodo para centrar el texto. </summary>
        /// <param name="texto">The texto.</param>
        public void TextoCentro(string texto)
        {
            if (texto.Length > maxCar)
            {
                int caracterActual = 0;//Nos indicara en que caracter se quedo al bajar el texto a la siguiente linea
                for (int longitudTexto = texto.Length; longitudTexto > maxCar; longitudTexto -= maxCar)
                {
                    //Agregamos los fragmentos que salgan del texto
                    Linea.AppendLine(texto.Substring(caracterActual, maxCar));
                    caracterActual += maxCar;
                }
                //Variable para poner espacios restntes
                string espacios = "";
                //sacamos la cantidad de espacios libres y el resultado lo dividimos entre dos
                int centrar = (maxCar - texto.Substring(caracterActual, texto.Length - caracterActual).Length) / 2;
                //Obtenemos la longitud del texto restante.
                for (int i = 0; i < centrar; i++)
                {
                    espacios += " ";//Agrega espacios para centrar
                }

                //agregamos el fragmento restante, agregamos antes del texto los espacios
                Linea.AppendLine(espacios + texto.Substring(caracterActual, texto.Length - caracterActual));
            }
            else
            {
                string espacios = "";
                //sacamos la cantidad de espacios libres y el resultado lo dividimos entre dos
                int centrar = (maxCar - texto.Length) / 2;
                //Obtenemos la longitud del texto restante.
                for (int i = 0; i < centrar; i++)
                {
                    espacios += " ";//Agrega espacios para centrar
                }

                //agregamos el fragmento restante, agregamos antes del texto los espacios
                Linea.AppendLine(espacios + texto);

            }
        }

        /// <summary> Metodo para poner texto a los extremos.</summary>
        /// <param name="textoIzquierdo">The texto izquierdo.</param>
        /// <param name="textoDerecho">The texto derecho.</param>
        public void TextoExtremos(string textoIzquierdo, string textoDerecho)
        {
            //variables que utilizaremos
            string textoIzq, textoDer, textoCompleto = "", espacios = "";

            //Si el texto que va a la izquierda es mayor a 18, cortamos el texto.
            if (textoIzquierdo.Length > 18)
            {
                cortar = textoIzquierdo.Length - 18;
                textoIzq = textoIzquierdo.Remove(18, cortar);
            }
            else
            { textoIzq = textoIzquierdo; }

            textoCompleto = textoIzq;//Agregamos el primer texto.

            if (textoDerecho.Length > 20)//Si es mayor a 20 lo cortamos
            {
                cortar = textoDerecho.Length - 20;
                textoDer = textoDerecho.Remove(20, cortar);
            }
            else
            { textoDer = textoDerecho; }

            //Obtenemos el numero de espacios restantes para poner textoDerecho al final
            int nroEspacios = maxCar - (textoIzq.Length + textoDer.Length);
            for (int i = 0; i < nroEspacios; i++)
            {
                espacios += " ";//agrega los espacios para poner textoDerecho al final
            }
            textoCompleto += espacios + textoDerecho;//Agregamos el segundo texto con los espacios para alinearlo a la derecha.
            Linea.AppendLine(textoCompleto);//agregamos la linea al ticket, al objeto en si.
        }

        /// <summary>Metodo para agregar los totales de la venta.</summary>
        /// <param name="texto">The texto.</param>
        /// <param name="total">The total.</param>
        public void AgregarTotales(string texto, double total)
        {
            //Variables que usaremos
            string resumen, valor, textoCompleto, espacios = "";

            if (texto.Length > 25)//Si es mayor a 25 lo cortamos
            {
                cortar = texto.Length - 25;
                resumen = texto.Remove(25, cortar);
            }
            else
            { resumen = texto; }

            textoCompleto = resumen;
            valor = total.ToString("#,#.00");//Agregamos el total previo formateo.

            //Obtenemos el numero de espacios restantes para alinearlos a la derecha
            int nroEspacios = maxCar - (resumen.Length + valor.Length);
            //agregamos los espacios
            for (int i = 0; i < nroEspacios; i++)
            {
                espacios += " ";
            }
            textoCompleto += espacios + valor;
            Linea.AppendLine(textoCompleto);
        }

        /// <summary> Metodo para agreagar articulos al ticket de venta.. </summary>
        /// <param name="articulo">The articulo.</param>
        /// <param name="cant">The cant.</param>
        /// <param name="precio">The precio.</param>
        /// <param name="importe">The importe.</param>
        /// <exception cref="System.Exception">Los valores ingresados para algunas filas del ticket\nsuperan las columnas soportdas por éste.</exception>
        public void AgregaArticulo(string articulo, double cant, double precio, double importe)
        {
            //Valida que cant precio e importe esten dentro del rango.
            if (cant.ToString().Length <= 5 && precio.ToString().Length <= 7 && importe.ToString().Length <= 8)
            {
                string elemento = "", espacios = "";
                bool primeraLinea = false;//Indicara si es la primera linea que se escribe cuando bajemos a la segunda si el nombre del articulo no entra en la primera linea
                int nroEspacios = 0;

                //Si el nombre o descripcion del articulo es mayor a 20, bajar a la siguiente linea
                if (articulo.Length > 20)
                {
                    //Colocar la cantidad a la derecha.
                    nroEspacios = (5 - cant.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";//Generamos los espacios necesarios para alinear a la derecha
                    }
                    elemento += espacios + cant.ToString();//agregamos la cantidad con los espacios

                    //Colocar el precio a la derecha.
                    nroEspacios = (7 - precio.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";//Genera los espacios
                    }
                    //el operador += indica que agregar mas cadenas a lo que ya existe.
                    elemento += espacios + precio.ToString();//Agregamos el precio a la variable elemento

                    //Colocar el importe a la derecha.
                    nroEspacios = (8 - importe.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elemento += espacios + importe.ToString();//Agregamos el importe alineado a la derecha

                    int caracterActual = 0;//Indicara en que caracter se quedo al bajae a la siguiente linea

                    //Por cada 20 caracteres se agregara una linea siguiente
                    for (int longitudTexto = articulo.Length; longitudTexto > 20; longitudTexto -= 20)
                    {
                        if (primeraLinea == false)//si es false o la primera linea en recorrerer, continuar...
                        {
                            //agregamos los primeros 20 caracteres del nombre del articulos, mas lo que ya tiene la variable elemento
                            Linea.AppendLine(articulo.Substring(caracterActual, 20) + elemento);
                            primeraLinea = true;//cambiamos su valor a verdadero
                        }
                        else
                            Linea.AppendLine(articulo.Substring(caracterActual, 20));//Solo agrega el nombre del articulo

                        caracterActual += 20;//incrementa en 20 el valor de la variable caracterActual
                    }
                    //Agrega el resto del fragmento del  nombre del articulo
                    Linea.AppendLine(articulo.Substring(caracterActual, articulo.Length - caracterActual));

                }
                else //Si no es mayor solo agregarlo, sin dar saltos de lineas
                {
                    for (int i = 0; i < (20 - articulo.Length); i++)
                    {
                        espacios += " "; //Agrega espacios para completar los 20 caracteres
                    }
                    elemento = articulo + espacios;

                    //Colocar la cantidad a la derecha.
                    nroEspacios = (5 - cant.ToString().Length);// +(20 - elemento.Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elemento += espacios + cant.ToString();

                    //Colocar el precio a la derecha.
                    nroEspacios = (7 - precio.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elemento += espacios + precio.ToString();

                    //Colocar el importe a la derecha.
                    nroEspacios = (8 - importe.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elemento += espacios + importe.ToString();

                    Linea.AppendLine(elemento);//Agregamos todo el elemento: nombre del articulo, cant, precio, importe.
                }
            }
            else
            {
                Linea.AppendLine("Los valores ingresados para esta fila");
                Linea.AppendLine("superan las columnas soportadas por este.");
                throw new Exception("Los valores ingresados para algunas filas del ticket\nsuperan las columnas soportdas por éste.");
            }
        }

        /// <summary>Metodos para enviar secuencias de escape a la impresora para cortar el ticket-.</summary>
        public void CortaTicket()
        {
            Linea.AppendLine("\x1B" + "m"); //Caracteres de corte. Estos comando varian segun el tipo de impresora
            Linea.AppendLine("\x1B" + "d" + "\x09"); //Avanza 9 renglones, Tambien varian
        }
        /// <summary> Para abrir el cajon. </summary>
        public void AbreCajon()
        {
            //Estos tambien varian, tienen que ever el manual de la impresora para poner los correctos.
            Linea.AppendLine("\x1B" + "p" + "\x00" + "\x0F" + "\x96"); //Caracteres de apertura cajon 0
            //linea.AppendLine("\x1B" + "p" + "\x01" + "\x0F" + "\x96"); //Caracteres de apertura cajon 1
        }
        /// <summary> Para mandara a imprimir el texto a la impresora que le indiquemos.. </summary>
        /// <param name="impresora">La impresora.</param>
        public void ImprimirTicket(string impresora)
        {
            //Este metodo recibe el nombre de la impresora a la cual se mandara a imprimir y el texto que se imprimira.
            //Usaremos un código que nos proporciona Microsoft. https://support.microsoft.com/es-es/kb/322091

            RawPrinterHelper.SendStringToPrinter(impresora, Linea.ToString()); //Imprime texto.
            Linea.Clear();//Al cabar de imprimir limpia la linea de todo el texto agregado.
        }
    }


    /// <summary>
    /// Clase para mandara a imprimir texto plano a la impresora
    /// </summary>
    public class RawPrinterHelper
    {
        /// <summary>Structure and API declarions: </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public class DOCINFOA
        {
            /// <summary>The p document name</summary>
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDocName;
            /// <summary>The p output file </summary>
            [MarshalAs(UnmanagedType.LPStr)]
            public string pOutputFile;
            /// <summary>The p data type</summary>
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDataType;
        }
        /// <summary> Opens the printer. </summary>
        /// <param name="szPrinter">The sz printer.</param>
        /// <param name="hPrinter">The h printer.</param>
        /// <param name="pd">The pd.</param>
        /// <returns></returns>
        [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

        /// <summary> Closes the printer.</summary>
        /// <param name="hPrinter">The h printer.</param>
        /// <returns></returns>
        [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool ClosePrinter(IntPtr hPrinter);

        /// <summary>Starts the document printer. </summary>
        /// <param name="hPrinter">The h printer.</param>
        /// <param name="level">The level.</param>
        /// <param name="di">The di.</param>
        /// <returns></returns>
        [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartDocPrinter(IntPtr hPrinter, Int32 level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

        /// <summary>Ends the document printer. </summary>
        /// <param name="hPrinter">The h printer.</param>
        /// <returns></returns>
        [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndDocPrinter(IntPtr hPrinter);

        /// <summary>Starts the page printer.</summary>
        /// <param name="hPrinter">The h printer.</param>
        /// <returns></returns>
        [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartPagePrinter(IntPtr hPrinter);

        /// <summary>Ends the page printer. </summary>
        /// <param name="hPrinter">The h printer.</param>
        /// <returns></returns>
        [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndPagePrinter(IntPtr hPrinter);

        /// <summary>Writes the printer.</summary>
        /// <param name="hPrinter">The h printer.</param>
        /// <param name="pBytes">The p bytes.</param>
        /// <param name="dwCount">The dw count.</param>
        /// <param name="dwWritten">The dw written.</param>
        /// <returns></returns>
        [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, out Int32 dwWritten);

        // SendBytesToPrinter()

        /// <summary>Envía los bytes a la impresora. </summary>
        // When the function is given a printer name and an unmanaged array
        // of bytes, the function sends those bytes to the print queue.
        // Returns true on success, false on failure.
        /// <param name="szPrinterName">Name of the sz printer.</param>
        /// <param name="pBytes">The p bytes.</param>
        /// <param name="dwCount">The dw count.</param>
        /// <returns> Si ha sucedido o no.</returns>
        public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, Int32 dwCount)
        {
            Int32 dwError = 0, dwWritten = 0;
            IntPtr hPrinter = new IntPtr(0);
            DOCINFOA di = new DOCINFOA();
            bool bSuccess = false; // Assume failure unless you specifically succeed.

            di.pDocName = "Ticket de Venta";//Este es el nombre con el que guarda el archivo en caso de no imprimir a la impresora fisica.
            di.pDataType = "RAW";//de tipo texto plano

            // Open the printer.
            if (OpenPrinter(szPrinterName.Normalize(), out hPrinter, IntPtr.Zero))
            {
                // Start a document.
                if (StartDocPrinter(hPrinter, 1, di))
                {
                    // Start a page.
                    if (StartPagePrinter(hPrinter))
                    {
                        // Write your bytes.
                        bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
                        EndPagePrinter(hPrinter);
                    }
                    EndDocPrinter(hPrinter);
                }
                ClosePrinter(hPrinter);
            }
            // If you did not succeed, GetLastError may give more information
            // about why not.
            if (bSuccess == false)
            {
                dwError = Marshal.GetLastWin32Error();
            }
            return bSuccess;
        }

        /// <summary>Envía la cadena a la impresora. </summary>
        /// <param name="szPrinterName">Name of the sz printer.</param>
        /// <param name="szString">The sz string.</param>
        /// <returns>Un booleano en true.</returns>
        public static bool SendStringToPrinter(string szPrinterName, string szString)
        {
            IntPtr pBytes;
            Int32 dwCount;
            // How many characters are in the string?
            dwCount = szString.Length;
            // Assume that the printer is expecting ANSI text, and then convert
            // the string to ANSI text.
            pBytes = Marshal.StringToCoTaskMemAnsi(szString);
            // Send the converted ANSI string to the printer.
            SendBytesToPrinter(szPrinterName, pBytes, dwCount);
            Marshal.FreeCoTaskMem(pBytes);
            return true;
        }
    }
    //
}
