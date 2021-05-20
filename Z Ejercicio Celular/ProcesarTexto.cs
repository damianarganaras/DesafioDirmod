using System;
using System.Globalization;

namespace Z_Ejercicio_Celular
{
    public class ProcesarTexto
    {
        public String teclas(String texto)
        {
            String secuencia = "";
            String aux = texto.ToUpper(new CultureInfo("en-US", false));
            char letraAnterior = (char)32;

            foreach (char c in aux)
            {
                if (letraAnterior == c)
                {
                    secuencia = secuencia + " ";
                }
                //********************** NUMERO 2 **********************
                if (c == 'A' || c == 'B' || c =='C')
                {
                    switch (c) {
                    case 'A':
                        secuencia = secuencia + "2";
                        break;

                    case 'B':
                        secuencia = secuencia + "22";
                        break;

                    case 'C':
                        secuencia = secuencia + "222";
                        break;
                    }
                //********************** NUMERO 3 **********************
                } else if(c == 'D' || c == 'E' || c =='F')
                {
                    switch (c) {
                    case 'D':
                        secuencia = secuencia + "3";
                        break;

                    case 'E':
                        secuencia = secuencia + "33";
                        break;

                    case 'F':
                        secuencia = secuencia + "333";
                        break;
                    }
                //********************** NUMERO 4 **********************
                } else if(c == 'G' || c == 'H' || c =='I')
                {
                    switch (c) {
                    case 'G':
                        secuencia = secuencia + "4";
                        break;

                    case 'H':
                        secuencia = secuencia + "44";
                        break;

                    case 'I':
                        secuencia = secuencia + "444";
                        break;
                    }
                //********************** NUMERO 5 **********************
                } else if(c == 'J' || c == 'L' || c =='K')
                {
                    switch (c) {
                    case 'J':
                        secuencia = secuencia + "5";
                        break;

                    case 'K':
                        secuencia = secuencia + "55";
                        break;

                    case 'L':
                        secuencia = secuencia + "555";
                        break;
                    }
                //********************** NUMERO 6 **********************
                } else if(c == 'M' || c == 'N' || c =='O')
                {
                    switch (c) {
                    case 'M':
                        secuencia = secuencia + "6";
                        break;

                    case 'N':
                        secuencia = secuencia + "66";
                        break;

                    case 'O':
                        secuencia = secuencia + "666";
                        break;
                    }
                //********************** NUMERO 7 **********************
                } else if(c == 'P' || c == 'Q' || c =='R' || c =='S')
                {
                    switch (c) {
                    case 'P':
                        secuencia = secuencia + "7";
                        break;

                    case 'Q':
                        secuencia = secuencia + "77";
                        break;

                    case 'R':
                        secuencia = secuencia + "777";
                        break;

                    case 'S':
                        secuencia = secuencia + "7777";
                        break;
                    }
                //********************** NUMERO 8 **********************
                } else if(c == 'T' || c == 'U' || c =='V')
                {
                    switch (c) {
                    case 'T':
                        secuencia = secuencia + "8";
                        break;

                    case 'U':
                        secuencia = secuencia + "88";
                        break;

                    case 'V':
                        secuencia = secuencia + "888";
                        break;
                    }
                //********************** NUMERO 9 **********************
                } else if(c == 'W' || c == 'X' || c =='Y' || c =='Z')
                {
                    switch (c) {
                    case 'W':
                        secuencia = secuencia + "9";
                        break;

                    case 'X':
                        secuencia = secuencia + "99";
                        break;

                    case 'Y':
                        secuencia = secuencia + "999";
                        break;

                    case 'Z':
                        secuencia = secuencia + "9999";
                        break;
                    }
                } else
                {
                    secuencia = secuencia + "0";
                }

                letraAnterior = c;

            }
            return secuencia;
        }
    }
}