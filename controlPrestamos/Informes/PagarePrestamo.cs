using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Windows.Forms;
using controlPrestamos.Properties;

namespace controlPrestamos.Informes
{
     class PagarePrestamo
    {
        //DATOS
        DataGridView dgvAmortizacion = new DataGridView();
        private  DateTime fechaInicio;


        public PagarePrestamo() { 
            
        }

        
        
        public void PrintPagare(string nombreCli, string prestamo, string cuotas, string direccion, string telefono, string nomAval, string dirAval, string telAval, decimal montoPagare, decimal porcentajePres, int numCuotas, DateTime InicioPRestamo, decimal cantPagoSemDia, int modalidadPago, string idCliente)
        {
            
            this.fechaInicio = InicioPRestamo;


           // GenerarAmotizacin();
            //Llama clase para calcular tasa y pagos y tabla de amortizacion

            Document doc_pdf = new Document(PageSize.Letter);
            doc_pdf.SetMargins(85.0394f, 85.0394f, 50.8661f, 70.8661f);
            //BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font arial9Bold = new Font(FontFactory.GetFont("Arial", 9, Font.BOLD));
            Font arial8 = new Font(FontFactory.GetFont("Arial", 9, Font.NORMAL));
            Font arial8Bold = new Font(FontFactory.GetFont("Arial", 9, Font.BOLD));
            Font TimesNewRoman10 = new Font(FontFactory.GetFont("Times New Roman", 10, Font.NORMAL));
            Font TimesNewRoman10Simple = new Font(FontFactory.GetFont("Times New Roman", 10));
            Font TimesNewRoman10Bold = new Font(FontFactory.GetFont("Times New Roman", 10, Font.BOLD));
            doc_pdf.AddTitle("Contrato");

            FileStream os = new FileStream("Pagare.pdf", FileMode.Create);

            using (os)
            {
                PdfWriter.GetInstance(doc_pdf, os);
                doc_pdf.Open();


                iTextSharp.text.Image img = Image.GetInstance(Resources.logo_finsanz_Ngo, System.Drawing.Imaging.ImageFormat.Png);
                img.BorderWidth = 0;
                img.Alignment = Element.ALIGN_LEFT;
                float percentaje = 120 / img.Width;
                img.ScalePercent(percentaje * 100);
                //doc_pdf.Add(img);
                var tblEncabezado = new PdfPTable(new float[] { 50f }) { WidthPercentage = 100f };

                var colDer = new PdfPCell(img) { PaddingLeft = 9, BorderColor = new BaseColor(255, 255, 255) };

                tblEncabezado.AddCell(colDer);

                doc_pdf.Add(tblEncabezado);

                //-----------------------    CARATULA DEL PRESTAMO --
                doc_pdf.Add(new Paragraph("Número de Cliente: " + idCliente, TimesNewRoman10) { Alignment = Element.ALIGN_RIGHT });
                doc_pdf.Add(new Paragraph("CARÁTULA DE CRÉDITO", TimesNewRoman10Bold) { Alignment = Element.ALIGN_CENTER });

                PdfPTable tableWithColSpan = new PdfPTable(4) { WidthPercentage = 100f };
                tableWithColSpan.SpacingBefore = 10;
                tableWithColSpan.SpacingAfter = 10;

                PdfPCell cellWithColspan = new PdfPCell();// The first cell spans 3 rows

                Paragraph parrafo = new Paragraph();
                Phrase seccion = new Phrase();

                seccion = new Phrase("Nombre Comercial del Producto: ", TimesNewRoman10Bold);
                parrafo.Add(seccion);
                seccion = new Phrase("Crédito Personal", TimesNewRoman10);
                parrafo.Add(seccion);
                seccion = new Phrase("\nTipo de Crédito: ", TimesNewRoman10Bold);
                parrafo.Add(seccion);
                seccion = new Phrase("Crédito Simpe", TimesNewRoman10);
                parrafo.Add(seccion);
                
                cellWithColspan.Colspan = 4;
                cellWithColspan.AddElement(parrafo);
                tableWithColSpan.AddCell(cellWithColspan);

                tableWithColSpan.AddCell(new PdfPCell(new Phrase("CAT(COSTO ANUAL TOTAL)", TimesNewRoman10Bold)) {HorizontalAlignment = Element.ALIGN_CENTER });
                tableWithColSpan.AddCell(new PdfPCell(new Phrase("TASA DE INTERES ANUAL\nORDINARIA Y MORATORIA", TimesNewRoman10Bold)) { HorizontalAlignment = Element.ALIGN_CENTER }); // Cell 2,1 does not exist
                tableWithColSpan.AddCell(new PdfPCell(new Phrase("MONTO DEL CREDITO", TimesNewRoman10Bold)) { HorizontalAlignment = Element.ALIGN_CENTER });
                tableWithColSpan.AddCell(new PdfPCell(new Phrase("MONTO TOTAL A PAGAR", TimesNewRoman10Bold)) { HorizontalAlignment = Element.ALIGN_CENTER }); // Cell 3,1 does not exist
                tableWithColSpan.AddCell(new PdfPCell(new Phrase(porcentajePres + "%" + " Sin I. V. A" + "\n\nPara fines informativos y de comparación", TimesNewRoman10Bold)) { HorizontalAlignment = Element.ALIGN_CENTER, PaddingBottom = 10f, PaddingTop = 10f });
                tableWithColSpan.AddCell(new PdfPCell(new Phrase(porcentajePres+"%"+" Fija." + "\n\nTasa moratoria 1.5 veces la tasa de interés ordinaria", TimesNewRoman10Bold)) { HorizontalAlignment = Element.ALIGN_CENTER, PaddingBottom = 10f, PaddingTop = 10f });
                tableWithColSpan.AddCell(new PdfPCell(new Phrase(montoPagare.ToString("C2"), TimesNewRoman10Bold)) { HorizontalAlignment = Element.ALIGN_CENTER, PaddingBottom = 10f, PaddingTop = 10f });
                tableWithColSpan.AddCell(new PdfPCell(new Phrase(prestamo, TimesNewRoman10Bold)) { HorizontalAlignment = Element.ALIGN_CENTER, PaddingBottom = 10f, PaddingTop = 10f });
                string tipo = "";
                DateTime fechLimit = fechaInicio;
                if (modalidadPago == 3)
                {
                    tipo = "Meses";
                    fechLimit = fechaInicio.AddDays(32 * int.Parse(cuotas));

                }
                else if (modalidadPago == 2)
                {
                    tipo = "Quincenas";
                    fechLimit = fechaInicio.AddDays(15 * int.Parse(cuotas));
                }
                else if (modalidadPago == 1)
                {
                    tipo = "Semanas";
                    fechLimit = fechaInicio.AddDays(8 * int.Parse(cuotas));
                }
                else if (modalidadPago == 0)
                {
                    tipo = "Dias";
                    fechLimit = fechaInicio.AddDays(1 * int.Parse(cuotas));
                }
                tableWithColSpan.AddCell(new PdfPCell(new Phrase("Plazo de Crédito: " + cuotas +" "+tipo, TimesNewRoman10Bold)) { HorizontalAlignment = Element.ALIGN_CENTER, PaddingBottom = 10f, PaddingTop = 10f });
                cellWithColspan = new PdfPCell(new Phrase("Fecha Límite de pago: " + fechLimit.ToString("MM-dd-yyyy"), TimesNewRoman10Bold)) { HorizontalAlignment = Element.ALIGN_LEFT, PaddingBottom = 10f, PaddingTop = 10f };
                cellWithColspan.Colspan = 3;
                tableWithColSpan.AddCell(cellWithColspan);
                cellWithColspan = new PdfPCell(new Phrase("COMISIONES RELEVANTES", TimesNewRoman10Bold)) { HorizontalAlignment = Element.ALIGN_CENTER, PaddingBottom = 8f, PaddingTop = 8f };
                cellWithColspan.Colspan = 4;
                tableWithColSpan.AddCell(cellWithColspan);
                cellWithColspan = new PdfPCell(new Phrase("Apertura: No aplica", TimesNewRoman10Bold)) { HorizontalAlignment = Element.ALIGN_LEFT, PaddingBottom = 15f, PaddingTop = 15f };
                cellWithColspan.Colspan = 2;
                tableWithColSpan.AddCell(cellWithColspan);
                cellWithColspan = new PdfPCell(new Phrase("No aplica", TimesNewRoman10)) { HorizontalAlignment = Element.ALIGN_LEFT, PaddingBottom = 15f, PaddingTop = 15f };
                cellWithColspan.Colspan = 2;
                tableWithColSpan.AddCell(cellWithColspan);
                cellWithColspan = new PdfPCell(new Phrase("ADVERTENCIA", TimesNewRoman10Bold)) { HorizontalAlignment = Element.ALIGN_CENTER, PaddingBottom = 10f, PaddingTop = 10f };
                cellWithColspan.Colspan = 4;
                tableWithColSpan.AddCell(cellWithColspan);
                cellWithColspan = new PdfPCell(new Phrase("Incumplir tus obligaciones te puede generar comisiones e intereses moratorios\nContratar créditos que excedan tu capacidad de pago puede afectar tu historial crediticio", TimesNewRoman10)) { HorizontalAlignment = Element.ALIGN_CENTER, PaddingBottom = 10f, PaddingTop = 10f };
                cellWithColspan.Colspan = 4;
                tableWithColSpan.AddCell(cellWithColspan);
                cellWithColspan = new PdfPCell(new Phrase("SEGUROS", TimesNewRoman10Bold)) { HorizontalAlignment = Element.ALIGN_CENTER, PaddingBottom = 10f, PaddingTop = 10f };
                cellWithColspan.Colspan = 4;
                tableWithColSpan.AddCell(cellWithColspan);
                tableWithColSpan.AddCell(new PdfPCell(new Phrase("No Aplica", TimesNewRoman10)) { HorizontalAlignment = Element.ALIGN_CENTER, PaddingBottom = 20f, PaddingTop = 20f });
                tableWithColSpan.AddCell(new PdfPCell(new Phrase(" ", TimesNewRoman10Bold)) { HorizontalAlignment = Element.ALIGN_CENTER, PaddingBottom = 20f, PaddingTop = 20f });
                cellWithColspan = new PdfPCell(new Phrase(" ", TimesNewRoman10Bold)) { HorizontalAlignment = Element.ALIGN_CENTER, PaddingBottom = 20f, PaddingTop = 20f };
                cellWithColspan.Colspan = 2;
                tableWithColSpan.AddCell(cellWithColspan);
                cellWithColspan = new PdfPCell(new Phrase("ESTADO DE CUENTA", TimesNewRoman10Bold)) { HorizontalAlignment = Element.ALIGN_LEFT, PaddingBottom = 15f, PaddingTop = 15f };
                cellWithColspan.Colspan = 4;
                tableWithColSpan.AddCell(cellWithColspan);
                cellWithColspan = new PdfPCell(new Phrase("EN SUCURSAL: (X)", TimesNewRoman10Bold)) { HorizontalAlignment = Element.ALIGN_LEFT, PaddingBottom = 10f, PaddingTop = 10f };
                cellWithColspan.Colspan = 4;
                tableWithColSpan.AddCell(cellWithColspan);

                parrafo = new Paragraph();
                seccion = new Phrase();

                seccion = new Phrase("Aclaraciones y reclamaciones: ", TimesNewRoman10Bold);
                parrafo.Add(seccion);
                seccion = new Phrase("\nDomicilio: ", TimesNewRoman10Bold);
                parrafo.Add(seccion);
                seccion = new Phrase("Cuarta oriente sur sin número, barrio las moras, Bochil, Chiapas", TimesNewRoman10);
                parrafo.Add(seccion);
                seccion = new Phrase("\nTeléfonos: ", TimesNewRoman10Bold);
                parrafo.Add(seccion);
                seccion = new Phrase("9191518187 o 9191408760", TimesNewRoman10);
                parrafo.Add(seccion);

                cellWithColspan.Colspan = 4;
                cellWithColspan.AddElement(parrafo);
                tableWithColSpan.AddCell(cellWithColspan);

                doc_pdf.Add(tableWithColSpan);

                //-----------------------END CARATULA PRESTAMO
                // PAGARÉ
                doc_pdf.Add(tblEncabezado);
                Paragraph paraPagare = new Paragraph() { SpacingAfter = 9f };
                Phrase section = new Phrase();
                section = new Phrase("PAGARÉ", TimesNewRoman10Bold);
                paraPagare.Add(section);
                paraPagare.Alignment = Element.ALIGN_RIGHT;
                doc_pdf.Add(paraPagare);

                paraPagare = new Paragraph() { SpacingAfter = 25f, Alignment = Element.ALIGN_JUSTIFIED };
                section = new Phrase("Por este pagaré me obligo incondicionalmente a pagar a la orden de", TimesNewRoman10);
                paraPagare.Add(section);
                section = new Phrase(" FINSANZ SA DE CV", TimesNewRoman10Bold);
                paraPagare.Add(section);
                section = new Phrase(", en el domicilio ", TimesNewRoman10);
                paraPagare.Add(section);
                section = new Phrase(" cuarta oriente sur sin número, barrio las moras, Bochil, Chiapas", TimesNewRoman10Bold);
                paraPagare.Add(section);
                section = new Phrase(" o en cualquier otro que se me requiera, la cantidad de ", TimesNewRoman10);
                paraPagare.Add(section);
                section = new Phrase(new Chunk(prestamo, TimesNewRoman10Bold) + " (M.N.) que me obligo a cubrir en " + new Chunk(cuotas, TimesNewRoman10Bold) + " pagos, vencidos y sucesivos, en la fecha de cada pago, de acuerdo a la siguiente tabla de amortización:", TimesNewRoman10Simple);
                paraPagare.Add(section);
                doc_pdf.Add(paraPagare);
                paraPagare.SetLeading(12, 0);


                //GENERAL TABLA AMORTIZACION
                var tblAmortizacion = new PdfPTable(new float[] { 50f, 50f }) { WidthPercentage = 70f, HorizontalAlignment = Element.ALIGN_LEFT, SpacingAfter = 12f };

                var col1A = new PdfPCell(new Paragraph("Importe Del prestamo", TimesNewRoman10)) { BorderColor = new BaseColor(255, 255, 255) };
                var col2A = new PdfPCell(new Paragraph(montoPagare.ToString("C2"), TimesNewRoman10)); ;
                col1A.HorizontalAlignment = Element.ALIGN_LEFT;
                col2A.HorizontalAlignment = Element.ALIGN_LEFT;
                tblAmortizacion.AddCell(col1A);
                tblAmortizacion.AddCell(col2A);
                col1A.Phrase = new Phrase("Tasa de Interés", TimesNewRoman10);
                col2A.Phrase = new Phrase(porcentajePres.ToString() + "%", TimesNewRoman10);
                tblAmortizacion.AddCell(col1A);
                tblAmortizacion.AddCell(col2A);
                col1A.Phrase = new Phrase("Fecha de inicio de prestamo", TimesNewRoman10);
                col2A.Phrase = new Phrase(InicioPRestamo.ToString("MM-dd-yyyy"), TimesNewRoman10);
                tblAmortizacion.AddCell(col1A);
                tblAmortizacion.AddCell(col2A);



                //Agregar tabla al documento
                decimal importeTotalPres = Math.Round(numCuotas * cantPagoSemDia,2); // -------------- TOTAL DEL PRESTAMO
                decimal importTotalInteres = Math.Round(importeTotalPres - montoPagare,2); // ----------TOTAL DEL INTERES
                decimal interesPagos = importTotalInteres / numCuotas;
                decimal abonoCapital = Math.Round(cantPagoSemDia - interesPagos,2); //ABONO CAPITAL
                cantPagoSemDia = Math.Round(cantPagoSemDia);
                doc_pdf.Add(tblAmortizacion);


                var tblAmortizacionDat = new PdfPTable(new float[] { 50f, 50f }) { WidthPercentage = 70f, HorizontalAlignment = Element.ALIGN_LEFT , SpacingAfter  = 20f};

                var col1ADat = new PdfPCell(new Paragraph("Pago Semanal o en Dias", TimesNewRoman10)) { BorderColor = new BaseColor(255, 255, 255) };
                var col2ADat = new PdfPCell(new Paragraph(cantPagoSemDia.ToString("C2"), TimesNewRoman10)); ;
                col1ADat.HorizontalAlignment = Element.ALIGN_LEFT;
                col2ADat.HorizontalAlignment = Element.ALIGN_LEFT;
                tblAmortizacionDat.AddCell(col1ADat);
                tblAmortizacionDat.AddCell(col2ADat);
                col1ADat.Phrase = new Phrase("Número de pagos", TimesNewRoman10);
                col2ADat.Phrase = new Phrase(cuotas, TimesNewRoman10);
                tblAmortizacionDat.AddCell(col1ADat);
                tblAmortizacionDat.AddCell(col2ADat);
                col1ADat.Phrase = new Phrase("Importe total de los intereses", TimesNewRoman10);
                col2ADat.Phrase = new Phrase(importTotalInteres.ToString("C2"), TimesNewRoman10);
                tblAmortizacionDat.AddCell(col1ADat);
                tblAmortizacionDat.AddCell(col2ADat);
                col1ADat.Phrase = new Phrase("Costo total del préstamo", TimesNewRoman10);
                col2ADat.Phrase = new Phrase(importeTotalPres.ToString("C2"), TimesNewRoman10);
                tblAmortizacionDat.AddCell(col1ADat);
                tblAmortizacionDat.AddCell(col2ADat);


                //Agregar tabla de encabezado al documento
                doc_pdf.Add(tblAmortizacionDat);

                //INICIA TABLA DE AMORTIZACION
                

                var tblamortPrinicipal = new PdfPTable(new float[] { 14.28f, 14.28f, 14.28f, 14.28f, 14.28f, 14.28f, 14.28f }) { WidthPercentage = 100f, HorizontalAlignment = Element.ALIGN_CENTER, SpacingAfter = 15f };
                var columna1 = new PdfPCell(new Paragraph("N.°", TimesNewRoman10Bold)) {HorizontalAlignment = Element.ALIGN_CENTER };
                var columna2 = new PdfPCell(new Paragraph("Fecha\nPago", TimesNewRoman10Bold)) { HorizontalAlignment = Element.ALIGN_CENTER };
                var columna3 = new PdfPCell(new Paragraph("Inicio\nSaldo", TimesNewRoman10)) { HorizontalAlignment = Element.ALIGN_CENTER };
                var columna4 = new PdfPCell(new Paragraph("Pago", TimesNewRoman10Bold)) { HorizontalAlignment = Element.ALIGN_CENTER };
                var columna5 = new PdfPCell(new Paragraph("Principal", TimesNewRoman10Bold)) { HorizontalAlignment = Element.ALIGN_CENTER };
                var columna6 = new PdfPCell(new Paragraph("Interés", TimesNewRoman10Bold)) { HorizontalAlignment = Element.ALIGN_CENTER };
                var columna7 = new PdfPCell(new Paragraph("Fin\nSaldo", TimesNewRoman10Bold)) { HorizontalAlignment = Element.ALIGN_CENTER };
                tblamortPrinicipal.AddCell(columna1);
                tblamortPrinicipal.AddCell(columna2);
                tblamortPrinicipal.AddCell(columna3);
                tblamortPrinicipal.AddCell(columna4);
                tblamortPrinicipal.AddCell(columna5);
                tblamortPrinicipal.AddCell(columna6);
                tblamortPrinicipal.AddCell(columna7);

                for (int i = 1; i <= numCuotas; i++) {
                    if (modalidadPago == 3)
                    {
                        fechaInicio = fechaInicio.AddMonths(1);
                    }
                    else if (modalidadPago == 2)
                    {
                        fechaInicio = fechaInicio.AddDays(15);
                    }
                    else if (modalidadPago == 1)
                    {
                        fechaInicio = fechaInicio.AddDays(7);
                    }
                    else if (modalidadPago == 0)
                    {
                        fechaInicio = fechaInicio.AddDays(1);
                    }


                    columna1.Phrase = new Phrase(i.ToString(), TimesNewRoman10);
                    columna2.Phrase = new Phrase(fechaInicio.ToString("MM-dd-yyyy"), TimesNewRoman10); ;
                    columna3.Phrase = new Phrase(montoPagare.ToString("C2"), TimesNewRoman10);
                    columna4.Phrase = new Phrase(cantPagoSemDia.ToString("C2"), TimesNewRoman10);
                    columna5.Phrase = new Phrase(abonoCapital.ToString("C2"), TimesNewRoman10);
                    columna6.Phrase = new Phrase(interesPagos.ToString("C2"), TimesNewRoman10);

                    montoPagare = Math.Round(montoPagare - abonoCapital,2);

                    columna7.Phrase = new Phrase(montoPagare.ToString("C2"), TimesNewRoman10);
                    tblamortPrinicipal.AddCell(columna1);
                    tblamortPrinicipal.AddCell(columna2);
                    tblamortPrinicipal.AddCell(columna3);
                    tblamortPrinicipal.AddCell(columna4);
                    tblamortPrinicipal.AddCell(columna5);
                    tblamortPrinicipal.AddCell(columna6);
                    tblamortPrinicipal.AddCell(columna7);


                    if (montoPagare <= 0) { break; }

                }

                doc_pdf.Add(tblamortPrinicipal);
                //END TBL AMORTIZACION







                paraPagare = new Paragraph() { SpacingAfter = 18f, Alignment = Element.ALIGN_JUSTIFIED };
                section = new Phrase("El incumplimiento en el pago de dos amortizaciones como máximo, da derecho al FINSANZ o a su tenedor a exigir el cumplimiento del saldo insoluto.", TimesNewRoman10);
                paraPagare.Add(section);
                paraPagare.SetLeading(12, 0);

                doc_pdf.Add(paraPagare);
                paraPagare = new Paragraph() { SpacingAfter = 9f, Alignment = Element.ALIGN_JUSTIFIED };
                section = new Phrase("Bochil, Chiapas, a " + DateTime.Now.ToString("m").ToUpperInvariant() + " de " + DateTime.Now.Year, TimesNewRoman10);
                paraPagare.Add(section);


                var tbl = new PdfPTable(new float[] { 40f,10F, 40f }) { WidthPercentage = 100f };

                var col1T = new PdfPCell() { BorderColor = new BaseColor(255, 255, 255),PaddingTop = 40F, PaddingBottom = 90f };
                var col2T = new PdfPCell() { BorderColor = new BaseColor(255, 255, 255), PaddingTop = 40F, PaddingBottom = 90f };
                var col3T = new PdfPCell() { BorderColor = new BaseColor(255, 255, 255), PaddingTop = 40F, PaddingBottom = 90f };
                col1T.HorizontalAlignment = Element.ALIGN_CENTER;
                col2T.HorizontalAlignment = Element.ALIGN_LEFT;
                col3T.HorizontalAlignment = Element.ALIGN_CENTER;
                col1T.Phrase = new Phrase("ACEPTO", TimesNewRoman10Bold);
                col2T.Phrase = new Phrase("", TimesNewRoman10Bold);
                col3T.Phrase = new Phrase("ACEPTO", TimesNewRoman10Bold);
                tbl.AddCell(col1T);
                tbl.AddCell(col2T);
                tbl.AddCell(col3T);
                var col1 = new PdfPCell() { BorderColor = new BaseColor(255, 255, 255) };
                var col2 = new PdfPCell() { BorderColor = new BaseColor(255, 255, 255) };
                var col3 = new PdfPCell() { BorderColor = new BaseColor(255, 255, 255) };
                col1.HorizontalAlignment = Element.ALIGN_CENTER;
                col2.HorizontalAlignment = Element.ALIGN_LEFT;
                col3.HorizontalAlignment = Element.ALIGN_CENTER;
                col1.Phrase = new Phrase("EL SUSCRIPTOR", TimesNewRoman10Bold);
                col2.Phrase = new Phrase("", TimesNewRoman10Bold);
                col3.Phrase = new Phrase("EL AVAL", TimesNewRoman10Bold);
                tbl.AddCell(col1);
                tbl.AddCell(col2);
                tbl.AddCell(col3);
                col1.Phrase = new Phrase(nombreCli, TimesNewRoman10Bold);
                col2.Phrase = new Phrase("", arial8);
                col3.Phrase = new Phrase(nomAval,TimesNewRoman10Bold);
                tbl.AddCell(col1);
                tbl.AddCell(col2);
                tbl.AddCell(col3);
                col1.Phrase = new Phrase(direccion, TimesNewRoman10Bold);
                col2.Phrase = new Phrase("", arial8);
                col3.Phrase = new Phrase(dirAval, TimesNewRoman10Bold);
                tbl.AddCell(col1);
                tbl.AddCell(col2);
                tbl.AddCell(col3);
                col1.Phrase = new Phrase("Telefono: " + telefono, TimesNewRoman10Bold);
                col2.Phrase = new Phrase("", arial8);
                col3.Phrase = new Phrase("Telefono: " + telAval, TimesNewRoman10Bold);
                tbl.AddCell(col1);
                tbl.AddCell(col2);
                tbl.AddCell(col3);


                doc_pdf.Add(paraPagare);
                doc_pdf.Add(tbl);
                doc_pdf.Close();
                //Abre el documento automaticamente
                System.Diagnostics.Process.Start("Pagare.pdf");

                //
            }


            //return;
        }
    }
}
