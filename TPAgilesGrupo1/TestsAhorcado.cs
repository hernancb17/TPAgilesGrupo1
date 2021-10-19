﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TPAgilesGrupo1.Model;

namespace TestsAhorcado
{
    [TestClass]
    public class TestArriesgarPalabra
    {
        [TestMethod]
        public void TestIntentoVacio()
        {
            Ahorcado juego = new Ahorcado();

            Assert.IsFalse(juego.ValidarIntento(""));
        }

        [TestMethod]
        public void TestIntentoCorrecto()
        {
            Ahorcado juego = new Ahorcado();

            var intento = "METODOLOGIAS AGILES";

            Assert.IsTrue(juego.ValidarIntento(intento));
        }

        [TestMethod]
        public void TestIntentoMinusculasMayusculasCorrecto()
        {
            Ahorcado juego = new Ahorcado();

            var intento = "MetodOlOgias AgIlEs";

            Assert.IsTrue(juego.ValidarIntento(intento));
        }

        [TestMethod]
        public void TestIntentoIncorrecto()
        {
            Ahorcado juego = new Ahorcado();

            var intento = "SCRUM ES UNA METODOLOGIA AGIL";

            Assert.IsFalse(juego.ValidarIntento(intento));
        }
    }

    [TestClass]
    public class TestIngresoUsuarios
    {
        [TestMethod]
        public void TestIngresoNombreVacio()
        {
            Invitado invitado = new Invitado();

            var nombre = "";

            Assert.IsFalse(invitado.ValidarIngreso(nombre));
        }

        [TestMethod]
        public void TestIngresoNombreValido()
        {
            Invitado invitado = new Invitado();

            var nombreInvitado = "juan";

            Assert.IsTrue(invitado.ValidarIngreso(nombreInvitado));
        }

        [TestMethod]
        public void TestIngresoNombreInvalidoCorto()
        {
            Invitado invitado = new Invitado();

            var nombreInvitado = "sa";

            Assert.IsTrue(!invitado.ValidarIngreso(nombreInvitado));
        }

        [TestMethod]
        public void TestIngresoNombreValidoConNumeros()
        {
            Invitado invitado = new Invitado();

            var nombreInvitado = "pedr1to";

            Assert.IsTrue(invitado.ValidarIngreso(nombreInvitado));
        }

        [TestMethod]
        public void TestIngresoNombreInvalidoLargo()
        {
            Invitado invitado = new Invitado();

            var nombreInvitado = "megustajugaralahorcado";

            Assert.IsTrue(!invitado.ValidarIngreso(nombreInvitado));
        }

        [TestMethod]
        public void TestIngresoNombreInvalidoCaracteres()
        {
            Invitado invitado = new Invitado();

            var nombreInvitado = "!@#$%@";

            Assert.IsTrue(!invitado.ValidarIngreso(nombreInvitado));
        }

        [TestMethod]
        public void TestIngresoNombreInvalidoEspacio()
        {
            Invitado invitado = new Invitado();

            var nombreInvitado = "juan perez";

            Assert.IsTrue(!invitado.ValidarIngreso(nombreInvitado));
        }
    }

    [TestClass]
    public class TestArriesgarLetra
    {
        [TestMethod]
        public void TestIngresoLetraCorrecta()
        {
            Ahorcado ahorcado = new Ahorcado();

            var letra = "a";

            Assert.IsTrue(ahorcado.ValidarLetra(letra));
        }

        [TestMethod]
        public void TestIngresoLetraIncorrecta()
        {
            Ahorcado ahorcado = new Ahorcado();

            var letra = "z";

            Assert.IsFalse(ahorcado.ValidarLetra(letra));
        }
    }
}