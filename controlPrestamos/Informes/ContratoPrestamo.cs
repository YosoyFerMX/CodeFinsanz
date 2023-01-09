using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using controlPrestamos.Properties;

namespace controlPrestamos.Informes
{
    class ContratoPrestamo
    {


        public static void PrintContrato(string nombreCli, string prestamo, string cuotas, string Direccion, string telefono,string nomAval, string dirAval, string telAval, decimal montoCapital, decimal porcentajePres, int cantCuotas,DateTime InicioPRestamo, decimal cantPagoSemDia, int modalidadPago, string idCliente) {


            Document doc_pdf = new Document(PageSize.Letter);
            //BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font arial9Bold = new Font(FontFactory.GetFont("Arial", 9, Font.BOLD));
            Font arial8 = new Font(FontFactory.GetFont("Arial", 9, Font.NORMAL));
            Font arial8Bold = new Font(FontFactory.GetFont("Arial", 9, Font.BOLD));
            Font TimesNewRoman10 = new Font(FontFactory.GetFont("Times New Roman", 10, Font.NORMAL));
            Font TimesNewRoman10Simple = new Font(FontFactory.GetFont("Times New Roman", 10));
            Font TimesNewRoman10Bold = new Font(FontFactory.GetFont("Times New Roman", 10, Font.BOLD));
            doc_pdf.AddTitle("Contrato");

            FileStream os = new FileStream("Contrato.pdf", FileMode.Create);

            using (os)
            {
                PdfWriter.GetInstance(doc_pdf, os);
                doc_pdf.Open();

                //string path = Path.GetFullPath("logo_finsanz_Ngo.png");

                iTextSharp.text.Image img = Image.GetInstance(Resources.logo_finsanz_Ngo, System.Drawing.Imaging.ImageFormat.Png);
                img.BorderWidth = 0;
                img.Alignment = Element.ALIGN_LEFT;
                float percentaje = 120 / img.Width;
                img.ScalePercent(percentaje * 100);
                //doc_pdf.Add(img);

                var tblEncabezado = new PdfPTable(new float[] { 50f, 50f }) { WidthPercentage = 100f };

                var colIzq = new PdfPCell(new Paragraph("CRÉDITO PERSONAL", arial8)) { HorizontalAlignment = Element.ALIGN_RIGHT, Padding = 25,PaddingRight = 30, BorderColor = new BaseColor(255, 255, 255) };
                var colDer = new PdfPCell(img) { PaddingLeft = 30, BorderColor = new BaseColor(255, 255, 255) };

                tblEncabezado.AddCell(colDer);
                tblEncabezado.AddCell(colIzq);
                doc_pdf.Add(tblEncabezado);
                doc_pdf.Add(Chunk.Newline);
                string text1 = @"CONTRATO DE APERTURA DE CRÉDITO SIMPLE QUE CELEBRAN FINSANZ SA DE CV, EN LO SUCESIVO “LA EMPRESA”; LA PERSONA FÍSICA CUYOS DATOS APARECEN REGISTRADOS EN LA SOLICITUD DE CRÉDITO," +
                    "EN LO SUCESIVO EL “CLIENTE”; DE CONFORMIDAD CON LAS SIGUIENTES DECLARACIONES Y CLÁUSULAS:";
                string text2 = @"D E C L A R A C I O N E S";
                string negrita1 = "Declara “LA EMPRESA”: (i) ";
                string text3 = @"Que es una Sociedad Mercantil legalmente existente de conformidad con la legislación mexicana y;";
                string chunk = " (ii) ";
                string text3y1 = @"que sus representantes cuentan," +
                    "con facultades para celebrar el presente Contrato, las cuales no han sido modificadas ni revocadas.";


                string text4chunk1 = @"Declara el Cliente: (i) ";
                string text4phrase1 = @"Que cuenta con la capacidad jurídica necesaria para recibir el crédito que “LA EMPRESA” le otorga, así como para obligarse en términos de este Contrato; ";
                string text4chunk2 = @"(ii)";
                string text4phrase2 = ", que son ciertos los datos plasmados en el formato suscrito por el Cliente y que en lo sucesivo se denominará Solicitud de Crédito, la cual debe considerarse parte integrante de este instrumento;";
                string text4chunk3 = " (iii) ";
                string text4phrase3 = " que previo a la firma de este Contrato, “LA EMPRESA” hizo de su conocimiento el contenido del mismo; la Carátula; el concepto, monto y periodicidad de las Comisiones, los intereses generados y demás gastos que se generan por su celebración y otorgamiento.";

                string text5 = @"C L Á U S U L A S";

                string text6Chunk1 = @"Primera. Definiciones.";
                string text6Phrase1 = " Las partes acuerdan que para efectos del presente Contrato, los términos que enseguida se refieren, tendrán el siguiente significado:";

                string text7Chunk1 = @"Capacidad de Pago:";
                string text7Phrase1 = " Monto máximo de liquidez mensual del Cliente tomando como base su ingreso bruto mensual menos los compromisos financieros y de acuerdo a las políticas de crédito establecidas por “LA EMPRESA”.";

                string text8Chunk1 = @"Carátula:";
                string text8Phrase1 = " Documento informativo generado por “LA EMPRESA” en términos de las disposiciones legales aplicables que contiene, entre otros aspectos, los elementos esenciales de la operación, las tasas de interés y el monto a pagar. Se entenderá que el Cliente otorga su consentimiento a la Carátula al momento de la disposición del crédito en los términos estipulados en el presente Contrato. La Carátula forma parte integrante del contrato.";

                string text9Chunk1 = @"Día Hábil:";
                string text9Phrase1 = " Cualquier día de la semana, excepto domingos y aquéllos en que LA EMPRESA  esté obligada a cerrar sus oficinas y sucursales, en términos de las disposiciones de carácter general que para tal efecto emita la Ley Federal del Trabajo.";

                string text10Chunk1 = @"Fecha de Pago:";
                string text10Phrase1 = " Es el numeral de cada mes que se señala para dar cumplimiento a la obligación, cuando dicha fecha se establezca en día inhábil bancario se recorrerá al próximo día hábil.";

                string text11Chunk1 = @"Fecha de Corte:";
                string text11Phrase1 = " El número de día calendario de cada mes que se indique en la carátula y en el estado de cuenta.";

                string text12Chunk1 = @"Periodo de intereses:";
                string text12Phrase1 = " Significa el lapso de tiempo con base en el cual se calcularán los intereses ordinarios que devengue el promedio de saldos diarios insolutos comprendido en las fechas de corte, comenzando el día siguiente a la Fecha de Corte y terminará en la Fecha de Corte del día o semana  inmediato siguiente; en el entendido de que el primer periodo de intereses comenzará a partir de la fecha de disposición del crédito y terminará en la Fecha de Corte inmediata siguiente. En el cómputo de intereses se incluirán todos los días del Período de Intereses.";

                string text13Chunk1 = @"Solicitud de Crédito:";
                string text13Phrase1 = " Es el formato impreso en el cual el solicitante proporciona sus datos personales, tales como nombre completo, domicilio y  demás información necesaria que “LA EMPRESA” le solicite, la cual forma parte integrante de este Contrato.";

                string text14Chunk1 = @"Cliente:";
                string text14Phrase1 = " A la persona que contrata un préstamo personal derivado de cualquier operación pasiva, activa o de servicios con  “LA EMPRESA”. Indistintamente, al cliente referido en el presente Contrato.";

                string text15Chunk1 = @"Tabla de Amortizaciones:";
                string text15Phrase1 = " Documento que refleja entre otros conceptos, el saldo insoluto de principal, el número, periodicidad y cuantía de los pagos, así como las primas de seguros e IVA, si fuera el caso desglosando cada uno de  los conceptos aplicables. Esta información se entregará al Cliente al momento de celebrar el contrato.";

                string text16Chunk1 = @"Segunda. Apertura de crédito.";
                string text16Phrase1 = " “LA EMPRESA” otorga en favor del Cliente una apertura de crédito simple hasta por la cantidad que se indica en la Carátula, cuyo monto, plazo y tasas de interés se determinaran al momento  de la disposición del crédito en función a la Capacidad de pago del Cliente  y de conformidad con las cláusulas contenidas en el presente Contrato. Dentro del límite de crédito no quedarán comprendidos los intereses, comisiones y gastos que se causen en virtud de este Contrato.";

                string text17Chunk1 = @"Tercera. Destino.";
                string text17Phrase1 = " El Cliente se obliga a destinar el importe del crédito otorgado para: apoyo a su liquidez sin ser utilizado para fines ilícitos.";

                string text18Chunk1 = @"Cuarta. Plazo del Contrato.";
                string text18Phrase1 = " El plazo del Contrato podrá ser 30 días o 12 semanas. No obstante lo anterior, el presente Contrato seguirá surtiendo sus efectos mientras existan saldos insolutos a cargo del Cliente. Los plazos antes establecidos en la presente cláusula podrán ser modificados de conformidad con las políticas de “LA EMPRESA”.";

                string text19Chunk1 = @"Quinta. Intereses ordinarios y moratorios. El Cliente se obliga a pagar a “LA EMPRESA”, sin necesidad de previo requerimiento, intereses ordinarios (más su respectivo Impuesto al Valor Agregado) sobre el saldo insoluto del crédito dispuesto, pagaderos el último día de cada periodo de intereses (diario o semanal, según lo especifique la carátula), calculados a razón de una tasa fija mensual expresada en puntos porcentuales y/o sus fracciones, pactada al momento de la disposición del crédito e indicada en la Carátula”.";
                string text19Phrase1 = " Los intereses ordinarios que se generen de conformidad con la Tasa de interés pactada, quedarán incluidos en los pagos que deba hacer el Cliente para liquidar el crédito.";

                string text20Chunk1 = @"Sexto. Pago de capital e intereses.";
                string text20Phrase1 = " El Cliente, sin necesidad de previo requerimiento, se obliga a pagar a “LA EMPRESA” en forma mensual, quincenal, catorcenal o semanal, según lo estipulado al momento de la disposición del crédito, las cantidades dispuestas más los intereses ordinarios que se causen. Los pagos podrán ser crecientes de capital y decrecientes de intereses o fijos de capital y decrecientes de intereses. El número de pagos, el monto de cada uno de éstos y las fechas de pago se registrarán en la Tabla de amortización.";

                string text21Chunk1 = @"Décima. Lugar, medios de pago y fechas de acreditamiento.";
                string text21Phrase1 = " Servicio de domiciliación. Todas las cantidades pagaderas por el Cliente a “LA EMPRESA” en relación con este Crédito, serán pagadas sin necesidad de requerimiento previo, en Pesos, en la fecha de su vencimiento (hora de la Ciudad de México) en cuarta oriente sur sin número, barrio las moras, Bochil, Chiapas de “LA EMPRESA” o en su caso por el COBRADOR que se ponga a disposición del Cliente para tal efecto. Si el día establecido para cualquier pago resulte inhábil, el pago deberá efectuarse el día hábil inmediato posterior, sin que proceda el cobro de comisiones o intereses moratorios.";

                string text22 = @"El Cliente podrá efectuar los pagos con efectivo y órdenes de transferencias de fondos, en el caso de las órdenes de transferencias de fondos podrán ser enviadas a solicitud del Cliente o por un tercero. Cada pago deberá acreditarse de acuerdo al medio de pago que se utilice, de la manera siguiente:";
                string text23Chunk1 = @"Décima segunda. Aplicación de pagos parciales.";
                string text23Phrase1 = " El Cliente está de acuerdo que los pagos parciales que realice por concepto de principal y accesorios del crédito a su cargo, serán aplicados por “LA EMPRESA”, hasta donde basten y alcancen, en el orden siguiente: (i) impuestos; (ii) gastos; (iii) comisiones; (iv) intereses moratorios; (v) intereses ordinarios vencidos; (vi) saldo principal insoluto vencido del crédito, en el entendido de que existiendo varias amortizaciones pendientes de ser restituidas, se aplicará primeramente al pago de aquella que haya sido la primera en haber vencido; (vii) intereses ordinarios vigentes y; (viii) amortización del principal por vencer. Sin perjuicio de lo anterior, el recibo por “LA EMPRESA” de cualquier cantidad para ser aplicada al saldo insoluto, no limitará ni extinguirá en manera alguna el derecho de “LA EMPRESA” a recibir intereses, demás accesorios o cualquier otra cantidad pagadera conforme al presente Contrato.";

                string text24Chunk1 = @"Décima tercera. Pagos anticipados y pagos adelantados.";
                string text24Phrase1 = " El Cliente podrá efectuar en cualquier tiempo pagos anticipados o adelantados en rembolso del crédito.";

                string text25Phrase1 = @"“LA EMPRESA” está obligado a recibir";
                string text25Chunk1 = " pagos anticipados";
                string text25Phrase2 = " siempre que: ";
                string text25Chunk2 = "(i). ";
                string text25Phrase3 = "El Cliente lo solicite por escrito; ";
                string text25Chunk3 = "(ii) ";
                string text25Phrase4 = "El Cliente se encuentre al corriente en los pagos exigibles de conformidad con el presente Contrato y; ";
                string text25Chunk4 = "(iii) ";
                string text25Phrase5 = "El importe del pago anticipado sea por una cantidad igual o mayor al pago que deba realizarse en el período mensual correspondiente.";

                string text26 = @"El hecho de que el Cliente anticipe abonos a capital, no lo exime de la obligación de efectuar los pagos mensuales que está obligada a cubrir.";
                string text27 = @"Tratándose de pagos anticipados parciales, “LA EMPRESA” deberá dar a conocer el nuevo saldo insoluto y el plazo al Cliente por escrito, en los propios estados de cuenta o a través de Internet si el Cliente cuenta con dicho servicio.";
                string text28Phrase1 = @"También, en caso de que el Cliente lo solicite, “LA EMPRESA” recibirá pagos que aún no sean exigibles con el fin de aplicarlos a cubrir pagos periódicos inmediatos siguientes, dichos pagos se denominarán como";
                string text28Chunk1 = " pagos adelantados";

                string text29Chunk1 = @"Décima octava. Terminación del contrato.";
                string text29Phrase1 = " Cualquiera de las partes podrá dar por terminado en cualquier momento el presente Contrato. El Cliente podrá solicitar en cualquier momento la terminación anticipada del Contrato, para estos efectos el Cliente deberá presentar una solicitud por escrito en cualquier sucursal de LA EMPRESA, ";

                string text30 = @"LA EMPRESA no generará cargo alguno al crédito y el Cliente no será responsable por los cargos que pudieran llegar a generarse al crédito posterior a la terminación de la relación contractual entre LA EMPRESA y el Cliente, excepto por los ya generados y no reflejados.";
                string text31 = @"LA EMPRESA dará por terminado el contrato el mismo día a aquél en que reciba la solicitud si no existen adeudos. En tanto no sea liquidada la totalidad de los adeudos derivados del presente instrumento, la terminación del mismo no surtirá efectos.";
                string text32Chunk1 = @"Vigésima. Cesión.";
                string text32Phrase1 = " El Cliente faculta de manera expresa a “LA EMPRESA” para ceder, descontar o negociar, ante cualquier institución de crédito del país, los derechos de crédito derivados de este Contrato.";

                string text33Chunk1 = @"Vigésima primera. Medios de comunicación.";
                string text33Phrase1 = " Siempre que en este Contrato no se estipule lo contrario, todos los avisos y notificaciones que se contemplan en el mismo dirigidas al Cliente se podrán realizar por mediante cualquiera de los siguientes medios: escrito entregado en el Domicilio del Cliente, adicionalmente podrán enviarse mediante avisos en el Estado de cuenta, carteles, listas, folletos, tableros, medios electrónicos o pizarrones visibles de forma ostensible en las sucursales cajeros automáticos, correo electrónico del Cliente, mensajes SMS y MMS, Internet teléfono, fax o cualquier otro Medio Electrónico.";

                string text34Chunk1 = @"Vigésima sexta. Domicilios.";
                string text34Phrase1 = " Para los efectos del contrato materia de este instrumento el Cliente señala como su domicilio el consignado en la Solicitud de crédito. Mientras el Cliente no notifique por escrito y de manera indubitable el cambio de su domicilio, todos los avisos, notificaciones y demás diligencias que se hagan en el domicilio señalado surtirán todos los efectos legales correspondientes. Es obligación del Cliente notificar a “LA EMPRESA” por escrito su cambio de domicilio. El Domicilio de “LA EMPRESA” es cuarta oriente sur sin número, barrio las moras, Bochil, Chiapas.";

                string text35Chunk1 = @"Vigésima novena. Tribunales competentes.";
                string text35Phrase1 = " Para la solución de cualquier controversia o conflicto que surgiere con motivo de la interpretación o cumplimiento de este contrato, las partes se someterán a los tribunales de Bochil, Chiapas, o del lugar de su otorgamiento, a la elección de la parte que resulte ser actora en el juicio que llegare a entablarse renunciado al fuero de cualquier otro domicilio que tengan en el presente o que pudieren adquirir en lo futuro.";

                string text36 = @"Trigésima. Entrega del Contrato, Carátula y Tabla de Amortización. En este acto “LA EMPRESA” entrega a “EL CLIENTE” el clausulado de este Contrato, carátula, tabla de amortización y sus anexos ";
                string text37 = @"Sin perjuicio de la aceptación expresa manifestada por el Cliente a través de la firma de la solicitud de crédito, la cual forma parte integrante de este contrato. Para los casos en que sea necesario el consentimiento de “EL CLIENTE” las Partes convienen que dicho consentimiento podrá otorgarse mediante firma autógrafa.";
                string text38 = @"El presente instrumento se otorga y firma en el lugar y fecha indicados en la Solicitud de crédito de este contrato que forma parte integrante del mismo. ";






                MultiColumnText columns = new MultiColumnText();
                columns.AddRegularColumns(70f, doc_pdf.PageSize.Width - 70f, 40f, 2);
                // parrrafo 1
                Paragraph tex = new Paragraph() { Alignment = Element.ALIGN_JUSTIFIED, SpacingAfter = 9f };
                Phrase phrase = new Phrase(text1, arial8Bold);
                tex.Add(phrase);
                tex.SetLeading(12, 0);
                columns.AddElement(tex);


                //parrafo 2
                tex = new Paragraph() { Alignment = Element.ALIGN_CENTER, SpacingAfter = 9f };
                phrase = new Phrase(text2, arial8Bold);
                tex.Add(phrase);
                columns.AddElement(tex);


                // Parrafo 3
                tex = new Paragraph() { Alignment = Element.ALIGN_JUSTIFIED, SpacingAfter = 9f };
                Chunk chunk1 = new Chunk(negrita1, arial8Bold);
                Phrase phrase1 = new Phrase(text3, arial8);
                Chunk chunk2 = new Chunk(chunk, arial8Bold);
                Phrase phrase2 = new Phrase(text3y1, arial8);
                Chunk chunk3 = new Chunk();
                Phrase phrase3 = new Phrase();
                Chunk chunk4 = new Chunk();
                Phrase phrase4 = new Phrase();
                Chunk chunk5 = new Chunk();
                Phrase phrase5 = new Phrase();
                tex.Add(chunk1);
                tex.Add(phrase1);
                tex.Add(chunk2);
                tex.Add(phrase2);

                tex.SetLeading(12, 0);
                columns.AddElement(tex);

                //columns.AddElement(new Paragraph(text3, arial8) { Alignment = Element.ALIGN_JUSTIFIED, SpacingAfter = 9f });
                //parra 4
                tex = new Paragraph() { Alignment = Element.ALIGN_JUSTIFIED, SpacingAfter = 9f };
                chunk1 = new Chunk(text4chunk1, arial8Bold);
                phrase1 = new Phrase(text4phrase1, arial8);
                chunk2 = new Chunk(text4chunk2, arial8Bold);
                phrase2 = new Phrase(text4phrase2, arial8);
                chunk3 = new Chunk(text4chunk3, arial8Bold);
                phrase3 = new Phrase(text4phrase3, arial8Bold);

                tex.Add(chunk1);
                tex.Add(phrase1);
                tex.Add(chunk2);
                tex.Add(phrase2);
                tex.Add(chunk3);
                tex.Add(phrase3);
                tex.SetLeading(12, 0);
                columns.AddElement(tex);
                //parra 5
                tex = new Paragraph() { Alignment = Element.ALIGN_CENTER, SpacingAfter = 9f };
                phrase = new Phrase(text5, arial8Bold);
                tex.Add(phrase);
                columns.AddElement(tex);
                //parra 6
                tex = new Paragraph() { Alignment = Element.ALIGN_JUSTIFIED, SpacingAfter = 9f };
                chunk1 = new Chunk(text6Chunk1, arial8Bold);
                phrase1 = new Phrase(text6Phrase1, arial8);

                tex.Add(chunk1);
                tex.Add(phrase1);
                tex.SetLeading(12, 0);
                columns.AddElement(tex);
                //parra 7
                tex = new Paragraph() { Alignment = Element.ALIGN_JUSTIFIED, SpacingAfter = 9f };
                chunk1 = new Chunk(text7Chunk1, arial8Bold);
                phrase1 = new Phrase(text7Phrase1, arial8);
                tex.Add(chunk1);
                tex.Add(phrase1);
                tex.SetLeading(12, 0);
                columns.AddElement(tex);
                //parra 8
                tex = new Paragraph() { Alignment = Element.ALIGN_JUSTIFIED, SpacingAfter = 9f };
                chunk1 = new Chunk(text8Chunk1, arial8Bold);
                phrase1 = new Phrase(text8Phrase1, arial8);
                tex.Add(chunk1);
                tex.Add(phrase1);
                tex.SetLeading(12, 0);
                columns.AddElement(tex);
                //parra 9
                tex = new Paragraph() { Alignment = Element.ALIGN_JUSTIFIED, SpacingAfter = 9f };
                chunk1 = new Chunk(text9Chunk1, arial8Bold);
                phrase1 = new Phrase(text9Phrase1, arial8);
                tex.Add(chunk1);
                tex.Add(phrase1);
                tex.SetLeading(12, 0);
                columns.AddElement(tex);
                //parra 10
                tex = new Paragraph() { Alignment = Element.ALIGN_JUSTIFIED, SpacingAfter = 9f };
                chunk1 = new Chunk(text10Chunk1, arial8Bold);
                phrase1 = new Phrase(text10Phrase1, arial8);
                tex.Add(chunk1);
                tex.Add(phrase1);
                tex.SetLeading(12, 0);
                columns.AddElement(tex);
                //parra 11
                tex = new Paragraph() { Alignment = Element.ALIGN_JUSTIFIED, SpacingAfter = 9f };
                chunk1 = new Chunk(text11Chunk1, arial8Bold);
                phrase1 = new Phrase(text11Phrase1, arial8);
                tex.Add(chunk1);
                tex.Add(phrase1);
                tex.SetLeading(12, 0);
                columns.AddElement(tex);
                //parra 12
                tex = new Paragraph() { Alignment = Element.ALIGN_JUSTIFIED, SpacingAfter = 9f };
                chunk1 = new Chunk(text12Chunk1, arial8Bold);
                phrase1 = new Phrase(text12Phrase1, arial8);
                tex.Add(chunk1);
                tex.Add(phrase1);
                tex.SetLeading(12, 0);
                columns.AddElement(tex);
                //parra 13
                tex = new Paragraph() { Alignment = Element.ALIGN_JUSTIFIED, SpacingAfter = 9f };
                chunk1 = new Chunk(text13Chunk1, arial8Bold);
                phrase1 = new Phrase(text13Phrase1, arial8);
                tex.Add(chunk1);
                tex.Add(phrase1);
                tex.SetLeading(12, 0);
                columns.AddElement(tex);
                //parra 14
                tex = new Paragraph() { Alignment = Element.ALIGN_JUSTIFIED, SpacingAfter = 9f };
                chunk1 = new Chunk(text14Chunk1, arial8Bold);
                phrase1 = new Phrase(text14Phrase1, arial8);
                tex.Add(chunk1);
                tex.Add(phrase1);
                tex.SetLeading(12, 0);
                columns.AddElement(tex);
                //parra 15
                tex = new Paragraph() { Alignment = Element.ALIGN_JUSTIFIED, SpacingAfter = 9f };
                chunk1 = new Chunk(text15Chunk1, arial8Bold);
                phrase1 = new Phrase(text15Phrase1, arial8);
                tex.Add(chunk1);
                tex.Add(phrase1);
                tex.SetLeading(12, 0);
                columns.AddElement(tex);
                //parra 16
                tex = new Paragraph() { Alignment = Element.ALIGN_JUSTIFIED, SpacingAfter = 9f };
                chunk1 = new Chunk(text16Chunk1, arial8Bold);
                phrase1 = new Phrase(text16Phrase1, arial8);
                tex.Add(chunk1);
                tex.Add(phrase1);
                tex.SetLeading(12, 0);
                columns.AddElement(tex);
                //parra 17
                tex = new Paragraph() { Alignment = Element.ALIGN_JUSTIFIED, SpacingAfter = 9f };
                chunk1 = new Chunk(text17Chunk1, arial8Bold);
                phrase1 = new Phrase(text17Phrase1, arial8);
                tex.Add(chunk1);
                tex.Add(phrase1);
                tex.SetLeading(12, 0);
                columns.AddElement(tex);
                //parra 18
                tex = new Paragraph() { Alignment = Element.ALIGN_JUSTIFIED, SpacingAfter = 9f };
                chunk1 = new Chunk(text18Chunk1, arial8Bold);
                phrase1 = new Phrase(text18Phrase1, arial8);
                tex.Add(chunk1);
                tex.Add(phrase1);
                tex.SetLeading(12, 0);
                columns.AddElement(tex);
                //parra 19
                tex = new Paragraph() { Alignment = Element.ALIGN_JUSTIFIED, SpacingAfter = 9f };
                chunk1 = new Chunk(text19Chunk1, arial8Bold);
                phrase1 = new Phrase(text19Phrase1, arial8);
                tex.Add(chunk1);
                tex.Add(phrase1);
                tex.SetLeading(12, 0);
                columns.AddElement(tex);
                //parra 20
                tex = new Paragraph() { Alignment = Element.ALIGN_JUSTIFIED, SpacingAfter = 9f };
                chunk1 = new Chunk(text20Chunk1, arial8Bold);
                phrase1 = new Phrase(text20Phrase1, arial8);
                tex.Add(chunk1);
                tex.Add(phrase1);
                tex.SetLeading(12, 0);
                columns.AddElement(tex);
                //parra 21
                tex = new Paragraph() { Alignment = Element.ALIGN_JUSTIFIED, SpacingAfter = 9f };
                chunk1 = new Chunk(text21Chunk1, arial8Bold);
                phrase1 = new Phrase(text21Phrase1, arial8);
                tex.Add(chunk1);
                tex.Add(phrase1);
                tex.SetLeading(12, 0);
                columns.AddElement(tex);
                //parra 22
                tex = new Paragraph() { Alignment = Element.ALIGN_JUSTIFIED, SpacingAfter = 9f };
                phrase = new Phrase(text22, arial8);
                tex.Add(phrase);
                tex.SetLeading(12, 0);
                columns.AddElement(tex);

                // Tabla

                var tbl = new PdfPTable(new float[] { 50f, 50f }) { WidthPercentage = 100f };

                var col1 = new PdfPCell(new Paragraph("Medios de Pago", arial8));
                var col2 = new PdfPCell(new Paragraph("Fechas de acreditamiento del pago:", arial8));
                col1.HorizontalAlignment = Element.ALIGN_LEFT;
                col2.HorizontalAlignment = Element.ALIGN_LEFT;
                tbl.AddCell(col1);
                tbl.AddCell(col2);
                col1.Phrase = new Phrase("Efectivo", arial8);
                col2.Phrase = new Phrase("Se acreditará el mismo día.", arial8);
                tbl.AddCell(col1);
                tbl.AddCell(col2);
                col1.Phrase = new Phrase("Tranferencias eletrónicas de fondos.", arial8);
                col2.Phrase = new Phrase("a) A través del Sistema de Pagos Electrónicos Interbancarios (SPEI) se acredtará el mismo día. \n\n b) Dentro de LA EMPRESA, se acreditará el mismo día. \n\n c) De otro banco se acreditará a más tardar el día hábil bancario siguiente.", arial8);
                tbl.AddCell(col1);
                tbl.AddCell(col2);
                columns.AddElement(tbl);
                //parra 23
                tex = new Paragraph() { Alignment = Element.ALIGN_JUSTIFIED, SpacingAfter = 9f };
                chunk1 = new Chunk(text23Chunk1, arial8Bold);
                phrase1 = new Phrase(text23Phrase1, arial8);
                tex.Add(chunk1);
                tex.Add(phrase1);
                tex.SetLeading(12, 0);
                columns.AddElement(tex);
                //parra 24
                tex = new Paragraph() { Alignment = Element.ALIGN_JUSTIFIED, SpacingAfter = 9f };
                chunk1 = new Chunk(text24Chunk1, arial8Bold);
                phrase1 = new Phrase(text24Phrase1, arial8);
                tex.Add(chunk1);
                tex.Add(phrase1);
                tex.SetLeading(12, 0);
                columns.AddElement(tex);
                //parra 25
                tex = new Paragraph() { Alignment = Element.ALIGN_JUSTIFIED, SpacingAfter = 9f };
                phrase1 = new Phrase(text25Phrase1, arial8);
                chunk1 = new Chunk(text25Chunk1, arial8Bold);
                phrase2 = new Phrase(text25Phrase2, arial8);
                chunk2 = new Chunk(text25Chunk2, arial8Bold);
                phrase3 = new Phrase(text25Phrase3, arial8);
                chunk3 = new Chunk(text25Chunk3, arial8Bold);
                phrase4 = new Phrase(text25Phrase4, arial8);
                chunk4 = new Chunk(text25Chunk4, arial8Bold);
                phrase5 = new Phrase(text25Phrase5, arial8);
                ;
                tex.Add(phrase1);
                tex.Add(chunk1);
                tex.Add(phrase2);
                tex.Add(chunk2);
                tex.Add(phrase3);
                tex.Add(chunk3);
                tex.Add(phrase4);
                tex.Add(chunk4);
                tex.Add(phrase5);
                tex.SetLeading(12, 0);
                columns.AddElement(tex);
                //parra 26
                tex = new Paragraph() { Alignment = Element.ALIGN_JUSTIFIED, SpacingAfter = 9f };
                phrase = new Phrase(text26, arial8);
                tex.Add(phrase);
                tex.SetLeading(12, 0);
                columns.AddElement(tex);
                //parra 27
                tex = new Paragraph() { Alignment = Element.ALIGN_JUSTIFIED, SpacingAfter = 9f };
                phrase = new Phrase(text27, arial8);
                tex.Add(phrase);
                tex.SetLeading(12, 0);
                columns.AddElement(tex);
                //parra 28
                tex = new Paragraph() { Alignment = Element.ALIGN_JUSTIFIED, SpacingAfter = 9f };
                chunk1 = new Chunk(text28Phrase1, arial8Bold);
                phrase1 = new Phrase(text28Chunk1, arial8);
                tex.Add(chunk1);
                tex.Add(phrase1);
                tex.SetLeading(12, 0);
                columns.AddElement(tex);
                //parra 29
                tex = new Paragraph() { Alignment = Element.ALIGN_JUSTIFIED, SpacingAfter = 9f };
                chunk1 = new Chunk(text29Chunk1, arial8Bold);
                phrase1 = new Phrase(text29Phrase1, arial8);
                tex.Add(chunk1);
                tex.Add(phrase1);
                tex.SetLeading(12, 0);
                columns.AddElement(tex);
                //parra 30
                tex = new Paragraph() { Alignment = Element.ALIGN_JUSTIFIED, SpacingAfter = 9f };
                phrase = new Phrase(text30, arial8);
                tex.Add(phrase);
                tex.SetLeading(12, 0);
                columns.AddElement(tex);
                //parra 31
                tex = new Paragraph() { Alignment = Element.ALIGN_JUSTIFIED, SpacingAfter = 9f };
                phrase = new Phrase(text31, arial8);
                tex.Add(phrase);
                tex.SetLeading(12, 0);
                columns.AddElement(tex);
                //parra 32
                tex = new Paragraph() { Alignment = Element.ALIGN_JUSTIFIED, SpacingAfter = 9f };
                chunk1 = new Chunk(text32Chunk1, arial8Bold);
                phrase1 = new Phrase(text32Phrase1, arial8);
                tex.Add(chunk1);
                tex.Add(phrase1);
                tex.SetLeading(12, 0);
                columns.AddElement(tex);
                //parra 33
                tex = new Paragraph() { Alignment = Element.ALIGN_JUSTIFIED, SpacingAfter = 9f };
                chunk1 = new Chunk(text33Chunk1, arial8Bold);
                phrase1 = new Phrase(text33Phrase1, arial8);
                tex.Add(chunk1);
                tex.Add(phrase1);
                tex.SetLeading(12, 0);
                columns.AddElement(tex);
                //parra 34
                tex = new Paragraph() { Alignment = Element.ALIGN_JUSTIFIED, SpacingAfter = 9f };
                chunk1 = new Chunk(text34Chunk1, arial8Bold);
                phrase1 = new Phrase(text34Phrase1, arial8);
                tex.Add(chunk1);
                tex.Add(phrase1);
                tex.SetLeading(12, 0);
                columns.AddElement(tex);
                //parra 35
                tex = new Paragraph() { Alignment = Element.ALIGN_JUSTIFIED, SpacingAfter = 9f };
                chunk1 = new Chunk(text35Chunk1, arial8Bold);
                phrase1 = new Phrase(text35Phrase1, arial8);
                tex.Add(chunk1);
                tex.Add(phrase1);
                tex.SetLeading(12, 0);
                columns.AddElement(tex);
                //parra 36
                tex = new Paragraph() { Alignment = Element.ALIGN_JUSTIFIED, SpacingAfter = 9f };
                phrase = new Phrase(text36, arial8Bold);
                tex.Add(phrase);
                tex.SetLeading(12, 0);
                columns.AddElement(tex);
                //parra 37
                tex = new Paragraph() { Alignment = Element.ALIGN_JUSTIFIED, SpacingAfter = 9f };
                phrase = new Phrase(text37, arial8);
                tex.Add(phrase);
                tex.SetLeading(12, 0);
                columns.AddElement(tex);
                //parra 38
                tex = new Paragraph() { Alignment = Element.ALIGN_JUSTIFIED, SpacingAfter = 9f };
                phrase = new Phrase(text38, arial8);
                tex.Add(phrase);
                tex.SetLeading(12, 0);
                columns.AddElement(tex);



                var tbl2 = new PdfPTable(new float[] { 100f }) { WidthPercentage = 100f };
                var colUnic = new PdfPCell(new Paragraph("FIRMAN", arial8Bold)) { Padding = 30f, HorizontalAlignment = Element.ALIGN_CENTER, BorderColor = new BaseColor(255, 255, 255) };
                var colUn2 = new PdfPCell(new Paragraph("EL CLIENTE", arial8Bold)) { Padding = 40f, HorizontalAlignment = Element.ALIGN_CENTER, BorderColor = new BaseColor(255, 255, 255) };
                var colUn3 = new PdfPCell(new Paragraph("__________________________________", arial8Bold)) { HorizontalAlignment = Element.ALIGN_CENTER, BorderColor = new BaseColor(255, 255, 255) };
                var colUn4 = new PdfPCell(new Paragraph(nombreCli, arial8Bold)) { HorizontalAlignment = Element.ALIGN_CENTER, BorderColor = new BaseColor(255, 255, 255) };
                var colUn5 = new PdfPCell(new Paragraph("LA EMPRESA", arial8Bold)) { Padding = 40f, HorizontalAlignment = Element.ALIGN_CENTER, BorderColor = new BaseColor(255, 255, 255) };
                var colUn6 = new PdfPCell(new Paragraph("__________________________________", arial8Bold)) { HorizontalAlignment = Element.ALIGN_CENTER, BorderColor = new BaseColor(255, 255, 255) };
                var colUn7 = new PdfPCell(new Paragraph("C. Hugo Sánchez Sánchez", arial8Bold)) { HorizontalAlignment = Element.ALIGN_CENTER, BorderColor = new BaseColor(255, 255, 255) };
                tbl2.AddCell(colUnic);
                tbl2.AddCell(colUn2);
                tbl2.AddCell(colUn3);
                tbl2.AddCell(colUn4);
                tbl2.AddCell(colUn5);
                tbl2.AddCell(colUn6);
                tbl2.AddCell(colUn7);

                columns.AddElement(tbl2);

                doc_pdf.Add(columns);



                doc_pdf.Close();
                //Abre el documento automaticamente
                System.Diagnostics.Process.Start("Contrato.pdf");


                PagarePrestamo abirPrint = new PagarePrestamo();
                abirPrint.PrintPagare(nombreCli, prestamo, cuotas, Direccion, telefono, nomAval, dirAval, telAval, montoCapital, porcentajePres, cantCuotas, InicioPRestamo, cantPagoSemDia, modalidadPago, idCliente);

                //
            }
            

            return;
        }



    }
}

