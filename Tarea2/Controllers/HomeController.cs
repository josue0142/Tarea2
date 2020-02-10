using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tarea2.Models;

namespace Tarea2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Colores
            //# CC99FF //Alcalinos
            //# FF99CC //AlcalinoTérreos
            //# FF9933 //MetalesdeTransicion / Bloque D
            //# CC6600 //Lantánidos
            //# FF9999 //Antínidos
            //# FFCC00 //OtrosMetales 
            //# CCCC00 //Metaloides
            //#99CC00 //OtrosnoMetales 
            //#66FFCC //Halógenos
            //#66CCFF //GasesNobles


            /*List<Element> elements = new List<Element> {
                new Element { Name = "H", Classification = "OtrosnoMetales",AtomicNumber = 1 },
                new Element { Name = "He", Classification = "GasesNobles",AtomicNumber = 2 },
                new Element { Name = "Li", Classification = "Alcalinos",AtomicNumber = 3 },
                new Element { Name = "Be", Classification = "AlcalinoTérreos",AtomicNumber = 4 },
                new Element { Name = "B", Classification = "Metaloides",AtomicNumber = 5 },
                new Element { Name = "C", Classification = "OtrosnoMetales",AtomicNumber = 6 },
                new Element { Name = "N", Classification = "OtrosnoMetales",AtomicNumber = 7 },
                new Element { Name = "O", Classification = "OtrosnoMetales",AtomicNumber = 8 },
                new Element { Name = "F", Classification = "Halógenos",AtomicNumber = 9 },
                new Element { Name = "Ne", Classification = "GasesNobles",AtomicNumber = 10 },
                new Element { Name = "Na", Classification = "Alcalinos",AtomicNumber = 11 },
                new Element { Name = "Mg", Classification = "AlcalinoTérreos",AtomicNumber = 12 },
                new Element { Name = "Al", Classification = "OtrosMetales",AtomicNumber = 13 },
                new Element { Name = "Si", Classification = "Metaloides",AtomicNumber = 14 },
                new Element { Name = "P", Classification = "OtrosnoMetales",AtomicNumber = 15 },
                new Element { Name = "S", Classification = "OtrosnoMetales",AtomicNumber = 16 },
                new Element { Name = "Cl", Classification = "Halógenos",AtomicNumber = 17 },
                new Element { Name = "Ar", Classification = "GasesNobles",AtomicNumber = 18 },
                new Element { Name = "K", Classification = "Alcalinos",AtomicNumber = 19 },
                new Element { Name = "Ca", Classification = "AlcalinoTérreos",AtomicNumber = 20 }, 
                new Element { Name = "Sc", Classification = "MetalesdeTransicion",AtomicNumber = 21 },
                new Element { Name = "Ti", Classification = "MetalesdeTransicion",AtomicNumber = 22 },
                new Element { Name = "V", Classification = "MetalesdeTransicion",AtomicNumber = 23 },
                new Element { Name = "Cr", Classification = "MetalesdeTransicion",AtomicNumber = 24 },
                new Element { Name = "Mn", Classification = "MetalesdeTransicion",AtomicNumber = 25 },
                new Element { Name = "Fe", Classification = "MetalesdeTransicion",AtomicNumber = 26 },
                new Element { Name = "Co", Classification = "MetalesdeTransicion",AtomicNumber = 27 },
                new Element { Name = "Ni", Classification = "MetalesdeTransicion",AtomicNumber = 28 },
                new Element { Name = "Cu", Classification = "MetalesdeTransicion",AtomicNumber = 29 }, 
                new Element { Name = "Zn", Classification = "MetalesdeTransicion",AtomicNumber = 30 }, 
                new Element { Name = "Ga", Classification = "OtrosMetales",AtomicNumber = 31 },
                new Element { Name = "Ge", Classification = "Metaloides",AtomicNumber = 32 },
                new Element { Name = "As", Classification = "Metaloides",AtomicNumber = 33 }, 
                new Element { Name = "Se", Classification = "OtrosnoMetales",AtomicNumber = 34 }, 
                new Element { Name = "Br", Classification = "Halógenos",AtomicNumber = 35 }, 
                new Element { Name = "Kr", Classification = "GasesNobles",AtomicNumber = 36 }, 
                new Element { Name = "Rb", Classification = "Alcalinos",AtomicNumber = 37 }, 
                new Element { Name = "Sr", Classification = "AlcalinoTérreos",AtomicNumber = 38 }, 
                new Element { Name = "Y", Classification = "MetalesdeTransicion",AtomicNumber = 39 }, 
                new Element { Name = "Zr", Classification = "MetalesdeTransicion",AtomicNumber = 40 }, 
                new Element { Name = "Nb", Classification = "MetalesdeTransicion",AtomicNumber = 41 }, 
                new Element { Name = "Mo", Classification = "MetalesdeTransicion",AtomicNumber = 42 }, 
                new Element { Name = "Tc", Classification = "MetalesdeTransicion",AtomicNumber = 43 }, 
                new Element { Name = "Ru", Classification = "MetalesdeTransicion",AtomicNumber = 44 }, 
                new Element { Name = "Rh", Classification = "MetalesdeTransicion",AtomicNumber = 45 }, 
                new Element { Name = "Pd", Classification = "MetalesdeTransicion",AtomicNumber = 46 },
                new Element { Name = "Ag", Classification = "MetalesdeTransicion",AtomicNumber = 47 },
                new Element { Name = "Cd", Classification = "MetalesdeTransicion",AtomicNumber = 48 }, 
                new Element { Name = "In", Classification = "OtrosMetales",AtomicNumber = 49 }, 
                new Element { Name = "Sn", Classification = "OtrosMetales",AtomicNumber = 50 },
                new Element { Name = "Sb", Classification = "Metaloides",AtomicNumber = 51 }, 
                new Element { Name = "Te", Classification = "Metaloides",AtomicNumber = 52 }, 
                new Element { Name = "I", Classification = "Halógenos",AtomicNumber = 53 }, 
                new Element { Name = "Xe", Classification = "GasesNobles",AtomicNumber = 54 }, 
                new Element { Name = "Cs", Classification = "Alcalinos",AtomicNumber = 55 },
                new Element { Name = "Ba", Classification = "AlcalinoTérreos",AtomicNumber = 56 },
                new Element { Name = "La-Lu", Classification = "Lantánidos",AtomicNumber = 57-71 },
                new Element { Name = "Hf", Classification = "MetalesdeTransicion",AtomicNumber = 72 },
                new Element { Name = "Ta", Classification = "MetalesdeTransicion",AtomicNumber = 73 },
                new Element { Name = "W", Classification = "MetalesdeTransicion",AtomicNumber = 74 },
                new Element { Name = "Re", Classification = "MetalesdeTransicion",AtomicNumber = 75 },
                new Element { Name = "Os", Classification = "MetalesdeTransicion",AtomicNumber = 76 },
                new Element { Name = "Ir", Classification = "MetalesdeTransicion",AtomicNumber = 77 },
                new Element { Name = "Pt", Classification = "MetalesdeTransicion",AtomicNumber = 78 },
                new Element { Name = "Au", Classification = "MetalesdeTransicion",AtomicNumber = 79 },
                new Element { Name = "Hg", Classification = "MetalesdeTransicion",AtomicNumber = 80 },
                new Element { Name = "Tl", Classification = "OtrosMetales",AtomicNumber = 81 },
                new Element { Name = "Pb", Classification = "OtrosMetales",AtomicNumber = 82 },
                new Element { Name = "Bi", Classification = "OtrosMetales",AtomicNumber = 82 },
                new Element { Name = "Po", Classification = "Metaloides",AtomicNumber = 84 },
                new Element { Name = "At", Classification = "Halógenos",AtomicNumber = 85 },
                new Element { Name = "Rn", Classification = "GasesNobles",AtomicNumber = 86 },
                new Element { Name = "Fr", Classification = "Alcalinos",AtomicNumber = 87 },
                new Element { Name = "Ra", Classification = "AlcalinoTérreos",AtomicNumber = 88 },
                new Element { Name = "Ac-Lr", Classification = "Antínidos",AtomicNumber = 89-103 },
                new Element { Name = "Rf", Classification = "MetalesdeTransicion",AtomicNumber = 104 },
                new Element { Name = "Db", Classification = "MetalesdeTransicion",AtomicNumber = 105 },
                new Element { Name = "Sg", Classification = "MetalesdeTransicion",AtomicNumber = 106 },
                new Element { Name = "Bh", Classification = "MetalesdeTransicion",AtomicNumber = 107 },
                new Element { Name = "Hs", Classification = "MetalesdeTransicion",AtomicNumber = 108 },
                new Element { Name = "Mt", Classification = "MetalesdeTransicion",AtomicNumber = 109 },
                new Element { Name = "Ds", Classification = "MetalesdeTransicion",AtomicNumber = 110 },
                new Element { Name = "Rg", Classification = "MetalesdeTransicion",AtomicNumber = 111 },
                new Element { Name = "Cn", Classification = "MetalesdeTransicion",AtomicNumber = 112 },
                new Element { Name = "Nh", Classification = "OtrosMetales",AtomicNumber = 113 },
                new Element { Name = "Fl", Classification = "OtrosMetales",AtomicNumber = 114 },
                new Element { Name = "Mc", Classification = "OtrosMetales",AtomicNumber = 115 },
                new Element { Name = "Lv", Classification = "OtrosMetales",AtomicNumber = 116 },
                new Element { Name = "Ts", Classification = "Halógenos",AtomicNumber = 117 },
                new Element { Name = "Og", Classification = "GasesNobles",AtomicNumber = 118 },
                 new Element { Name = "La", Classification = "Lantánidos",AtomicNumber = 57 },
                new Element { Name = "Ce", Classification = "Lantánidos",AtomicNumber = 58 },
                new Element { Name = "Pr", Classification = "Lantánidos",AtomicNumber = 59 },
                new Element { Name = "Nd", Classification = "Lantánidos",AtomicNumber = 60 },
                new Element { Name = "Pm", Classification = "Lantánidos",AtomicNumber = 61 },
                new Element { Name = "Sm", Classification = "Lantánidos",AtomicNumber = 62 },
                new Element { Name = "Eu", Classification = "Lantánidos",AtomicNumber = 63 },
                new Element { Name = "Gd", Classification = "Lantánidos",AtomicNumber = 64 },
                new Element { Name = "Tb", Classification = "Lantánidos",AtomicNumber = 65 },
                new Element { Name = "Dy", Classification = "Lantánidos",AtomicNumber = 66 },
                new Element { Name = "Ho", Classification = "Lantánidos",AtomicNumber = 67 },
                new Element { Name = "Er", Classification = "Lantánidos",AtomicNumber = 68 },
                new Element { Name = "Tm", Classification = "Lantánidos",AtomicNumber = 69 },
                new Element { Name = "Yb", Classification = "Lantánidos",AtomicNumber = 70 },
                new Element { Name = "Lu", Classification = "Lantánidos",AtomicNumber = 71 },
                new Element { Name = "Ac", Classification = "Antínidos",AtomicNumber = 89 }, 
                new Element { Name = "Th", Classification = "Antínidos",AtomicNumber = 90 }, 
                new Element { Name = "Pa", Classification = "Antínidos",AtomicNumber = 91 }, 
                new Element { Name = "U", Classification = "Antínidos",AtomicNumber = 92 }, 
                new Element { Name = "Np", Classification = "Antínidos",AtomicNumber = 93 },
                new Element { Name = "Pu", Classification = "Antínidos",AtomicNumber = 94 }, 
                new Element { Name = "Am", Classification = "Antínidos",AtomicNumber = 95 },
                new Element { Name = "Cm", Classification = "Antínidos",AtomicNumber = 96 },
                new Element { Name = "Bk", Classification = "Antínidos",AtomicNumber = 97 },
                new Element { Name = "Cf", Classification = "Antínidos",AtomicNumber = 98 },
                new Element { Name = "Es", Classification = "Antínidos",AtomicNumber = 99 },
                new Element { Name = "Fm", Classification = "Antínidos",AtomicNumber = 100 },
                new Element { Name = "Md", Classification = "Antínidos",AtomicNumber = 101 },
                new Element { Name = "No", Classification = "Antínidos",AtomicNumber = 102 },
                new Element { Name = "Lr", Classification = "Antínidos",AtomicNumber = 103 },               
            };*/

            List<Element> elements = new List<Element>(120);

            elements.Insert(0, new Element { Name = "H", Classification = "OtrosnoMetales", AtomicNumber = 1 });
            elements.Insert(1, new Element { Name = "He", Classification = "GasesNobles", AtomicNumber = 2 });
            elements.Insert(2, new Element { Name = "Li", Classification = "Alcalinos", AtomicNumber = 3 });
            elements.Insert(3, new Element { Name = "Be", Classification = "AlcalinoTérreos", AtomicNumber = 4 });
            elements.Insert(4, new Element { Name = "B", Classification = "Metaloides", AtomicNumber = 5 });
            elements.Insert(5, new Element { Name = "C", Classification = "OtrosnoMetales", AtomicNumber = 6 });
            elements.Insert(6, new Element { Name = "N", Classification = "OtrosnoMetales", AtomicNumber = 7 });
            elements.Insert(7, new Element { Name = "O", Classification = "OtrosnoMetales", AtomicNumber = 8 });
            elements.Insert(8, new Element { Name = "F", Classification = "Halógenos", AtomicNumber = 9 });
            elements.Insert(9, new Element { Name = "Ne", Classification = "GasesNobles", AtomicNumber = 10 });
            elements.Insert(10, new Element { Name = "Na", Classification = "Alcalinos", AtomicNumber = 11 });
            elements.Insert(11, new Element { Name = "Mg", Classification = "AlcalinoTérreos", AtomicNumber = 12 });
            elements.Insert(12, new Element { Name = "Al", Classification = "OtrosMetales", AtomicNumber = 13 });
            elements.Insert(13, new Element { Name = "Si", Classification = "Metaloides", AtomicNumber = 14 });
            elements.Insert(14, new Element { Name = "P", Classification = "OtrosnoMetales", AtomicNumber = 15 });
            elements.Insert(15, new Element { Name = "S", Classification = "OtrosnoMetales", AtomicNumber = 16 });
            elements.Insert(16, new Element { Name = "Cl", Classification = "Halógenos", AtomicNumber = 17 });
            elements.Insert(17, new Element { Name = "Ar", Classification = "GasesNobles", AtomicNumber = 18 });
            elements.Insert(18, new Element { Name = "K", Classification = "Alcalinos", AtomicNumber = 19 });
            elements.Insert(19, new Element { Name = "Ca", Classification = "AlcalinoTérreos", AtomicNumber = 20 });
            elements.Insert(20, new Element { Name = "Sc", Classification = "MetalesdeTransicion", AtomicNumber = 21 });
            elements.Insert(21, new Element { Name = "Ti", Classification = "MetalesdeTransicion", AtomicNumber = 22 });
            elements.Insert(22, new Element { Name = "V", Classification = "MetalesdeTransicion", AtomicNumber = 23 });
            elements.Insert(23, new Element { Name = "Cr", Classification = "MetalesdeTransicion", AtomicNumber = 24 });
            elements.Insert(24, new Element { Name = "Mn", Classification = "MetalesdeTransicion", AtomicNumber = 25 });
            elements.Insert(25, new Element { Name = "Fe", Classification = "MetalesdeTransicion", AtomicNumber = 26 });
            elements.Insert(26, new Element { Name = "Co", Classification = "MetalesdeTransicion", AtomicNumber = 27 });
            elements.Insert(27, new Element { Name = "Ni", Classification = "MetalesdeTransicion", AtomicNumber = 28 });
            elements.Insert(28, new Element { Name = "Cu", Classification = "MetalesdeTransicion", AtomicNumber = 29 });
            elements.Insert(29, new Element { Name = "Zn", Classification = "MetalesdeTransicion", AtomicNumber = 30 });
            elements.Insert(30, new Element { Name = "Ga", Classification = "OtrosMetales", AtomicNumber = 31 });
            elements.Insert(31, new Element { Name = "Ge", Classification = "Metaloides", AtomicNumber = 32 });
            elements.Insert(32, new Element { Name = "As", Classification = "Metaloides", AtomicNumber = 33 });
            elements.Insert(33, new Element { Name = "Se", Classification = "OtrosnoMetales", AtomicNumber = 34 });
            elements.Insert(34, new Element { Name = "Br", Classification = "Halógenos", AtomicNumber = 35 });
            elements.Insert(35, new Element { Name = "Kr", Classification = "GasesNobles", AtomicNumber = 36 });
            elements.Insert(36, new Element { Name = "Rb", Classification = "Alcalinos", AtomicNumber = 37 });
            elements.Insert(37, new Element { Name = "Sr", Classification = "AlcalinoTérreos", AtomicNumber = 38 });
            elements.Insert(38, new Element { Name = "Y", Classification = "MetalesdeTransicion", AtomicNumber = 39 });
            elements.Insert(39, new Element { Name = "Zr", Classification = "MetalesdeTransicion", AtomicNumber = 40 });
            elements.Insert(40, new Element { Name = "Nb", Classification = "MetalesdeTransicion", AtomicNumber = 41 });
            elements.Insert(41, new Element { Name = "Mo", Classification = "MetalesdeTransicion", AtomicNumber = 42 });
            elements.Insert(42, new Element { Name = "Tc", Classification = "MetalesdeTransicion", AtomicNumber = 43 });
            elements.Insert(43, new Element { Name = "Ru", Classification = "MetalesdeTransicion", AtomicNumber = 44 });
            elements.Insert(44, new Element { Name = "Rh", Classification = "MetalesdeTransicion", AtomicNumber = 45 });
            elements.Insert(45, new Element { Name = "Pd", Classification = "MetalesdeTransicion", AtomicNumber = 46 });
            elements.Insert(46, new Element { Name = "Ag", Classification = "MetalesdeTransicion", AtomicNumber = 47 });
            elements.Insert(47, new Element { Name = "Cd", Classification = "MetalesdeTransicion", AtomicNumber = 48 });
            elements.Insert(48, new Element { Name = "In", Classification = "OtrosMetales", AtomicNumber = 49 });
            elements.Insert(49, new Element { Name = "Sn", Classification = "OtrosMetales", AtomicNumber = 50 });
            elements.Insert(50, new Element { Name = "Sb", Classification = "Metaloides", AtomicNumber = 51 });
            elements.Insert(51, new Element { Name = "Te", Classification = "Metaloides", AtomicNumber = 52 });
            elements.Insert(52, new Element { Name = "I", Classification = "Halógenos", AtomicNumber = 53 });
            elements.Insert(53, new Element { Name = "Xe", Classification = "GasesNobles", AtomicNumber = 54 });
            elements.Insert(54, new Element { Name = "Cs", Classification = "Alcalinos", AtomicNumber = 55 });
            elements.Insert(55, new Element { Name = "Ba", Classification = "AlcalinoTérreos", AtomicNumber = 56 });
            elements.Insert(56, new Element { Name = "La-Lu", Classification = "Lantánidos", AtomicNumber = 57 - 71 });
            elements.Insert(57, new Element { Name = "Hf", Classification = "MetalesdeTransicion", AtomicNumber = 72 });
            elements.Insert(58, new Element { Name = "Ta", Classification = "MetalesdeTransicion", AtomicNumber = 73 });
            elements.Insert(59, new Element { Name = "W", Classification = "MetalesdeTransicion", AtomicNumber = 74 });
            elements.Insert(60, new Element { Name = "Re", Classification = "MetalesdeTransicion", AtomicNumber = 75 });
            elements.Insert(61, new Element { Name = "Os", Classification = "MetalesdeTransicion", AtomicNumber = 76 });
            elements.Insert(62, new Element { Name = "Ir", Classification = "MetalesdeTransicion", AtomicNumber = 77 });
            elements.Insert(63, new Element { Name = "Pt", Classification = "MetalesdeTransicion", AtomicNumber = 78 });
            elements.Insert(64, new Element { Name = "Au", Classification = "MetalesdeTransicion", AtomicNumber = 79 });
            elements.Insert(65, new Element { Name = "Hg", Classification = "MetalesdeTransicion", AtomicNumber = 80 });
            elements.Insert(66, new Element { Name = "Tl", Classification = "OtrosMetales", AtomicNumber = 81 });
            elements.Insert(67, new Element { Name = "Pb", Classification = "OtrosMetales", AtomicNumber = 82 });
            elements.Insert(68, new Element { Name = "Bi", Classification = "OtrosMetales", AtomicNumber = 82 });
            elements.Insert(69, new Element { Name = "Po", Classification = "Metaloides", AtomicNumber = 84 });
            elements.Insert(70, new Element { Name = "At", Classification = "Halógenos", AtomicNumber = 85 });
            elements.Insert(71, new Element { Name = "Rn", Classification = "GasesNobles", AtomicNumber = 86 });
            elements.Insert(72, new Element { Name = "Fr", Classification = "Alcalinos", AtomicNumber = 87 });
            elements.Insert(73, new Element { Name = "Ra", Classification = "AlcalinoTérreos", AtomicNumber = 88 });
            elements.Insert(74, new Element { Name = "Ac-Lr", Classification = "Antínidos", AtomicNumber = 89 - 103 });
            elements.Insert(75, new Element { Name = "Rf", Classification = "MetalesdeTransicion", AtomicNumber = 104 });
            elements.Insert(76, new Element { Name = "Db", Classification = "MetalesdeTransicion", AtomicNumber = 105 });
            elements.Insert(77, new Element { Name = "Sg", Classification = "MetalesdeTransicion", AtomicNumber = 106 });
            elements.Insert(78, new Element { Name = "Bh", Classification = "MetalesdeTransicion", AtomicNumber = 107 });
            elements.Insert(79, new Element { Name = "Hs", Classification = "MetalesdeTransicion", AtomicNumber = 108 });
            elements.Insert(80, new Element { Name = "Mt", Classification = "MetalesdeTransicion", AtomicNumber = 109 });
            elements.Insert(81, new Element { Name = "Ds", Classification = "MetalesdeTransicion", AtomicNumber = 110 });
            elements.Insert(82, new Element { Name = "Rg", Classification = "MetalesdeTransicion", AtomicNumber = 111 });
            elements.Insert(83, new Element { Name = "Cn", Classification = "MetalesdeTransicion", AtomicNumber = 112 });
            elements.Insert(84, new Element { Name = "Nh", Classification = "OtrosMetales", AtomicNumber = 113 });
            elements.Insert(85, new Element { Name = "Fl", Classification = "OtrosMetales", AtomicNumber = 114 });
            elements.Insert(86, new Element { Name = "Mc", Classification = "OtrosMetales", AtomicNumber = 115 });
            elements.Insert(87, new Element { Name = "Lv", Classification = "OtrosMetales", AtomicNumber = 116 });
            elements.Insert(88, new Element { Name = "Ts", Classification = "Halógenos", AtomicNumber = 117 });
            elements.Insert(89, new Element { Name = "Og", Classification = "GasesNobles", AtomicNumber = 118 });
            elements.Insert(90, new Element { Name = "La", Classification = "Lantánidos", AtomicNumber = 57 });
            elements.Insert(91, new Element { Name = "Ce", Classification = "Lantánidos", AtomicNumber = 58 });
            elements.Insert(92, new Element { Name = "Pr", Classification = "Lantánidos", AtomicNumber = 59 });
            elements.Insert(93, new Element { Name = "Nd", Classification = "Lantánidos", AtomicNumber = 60 });
            elements.Insert(94, new Element { Name = "Pm", Classification = "Lantánidos", AtomicNumber = 61 });
            elements.Insert(95, new Element { Name = "Sm", Classification = "Lantánidos", AtomicNumber = 62 });
            elements.Insert(96, new Element { Name = "Eu", Classification = "Lantánidos", AtomicNumber = 63 });
            elements.Insert(97, new Element { Name = "Gd", Classification = "Lantánidos", AtomicNumber = 64 });
            elements.Insert(98, new Element { Name = "Tb", Classification = "Lantánidos", AtomicNumber = 65 });
            elements.Insert(99, new Element { Name = "Dy", Classification = "Lantánidos", AtomicNumber = 66 });
            elements.Insert(100, new Element { Name = "Ho", Classification = "Lantánidos", AtomicNumber = 67 });
            elements.Insert(101, new Element { Name = "Er", Classification = "Lantánidos", AtomicNumber = 68 });
            elements.Insert(102, new Element { Name = "Tm", Classification = "Lantánidos", AtomicNumber = 69 });
            elements.Insert(103, new Element { Name = "Yb", Classification = "Lantánidos", AtomicNumber = 70 });
            elements.Insert(104, new Element { Name = "Lu", Classification = "Lantánidos", AtomicNumber = 71 });
            elements.Insert(105, new Element { Name = "Ac", Classification = "Antínidos", AtomicNumber = 89 });
            elements.Insert(106, new Element { Name = "Th", Classification = "Antínidos", AtomicNumber = 90 });
            elements.Insert(107, new Element { Name = "Pa", Classification = "Antínidos", AtomicNumber = 91 });
            elements.Insert(108, new Element { Name = "U", Classification = "Antínidos", AtomicNumber = 92 });
            elements.Insert(109, new Element { Name = "Np", Classification = "Antínidos", AtomicNumber = 93 });
            elements.Insert(110, new Element { Name = "Pu", Classification = "Antínidos", AtomicNumber = 94 });
            elements.Insert(111, new Element { Name = "Am", Classification = "Antínidos", AtomicNumber = 95 });
            elements.Insert(112, new Element { Name = "Cm", Classification = "Antínidos", AtomicNumber = 96 });
            elements.Insert(113, new Element { Name = "Bk", Classification = "Antínidos", AtomicNumber = 97 });
            elements.Insert(114, new Element { Name = "Cf", Classification = "Antínidos", AtomicNumber = 98 });
            elements.Insert(115, new Element { Name = "Es", Classification = "Antínidos", AtomicNumber = 99 });
            elements.Insert(116, new Element { Name = "Fm", Classification = "Antínidos", AtomicNumber = 100 });
            elements.Insert(117, new Element { Name = "Md", Classification = "Antínidos", AtomicNumber = 101 });
            elements.Insert(118, new Element { Name = "No", Classification = "Antínidos", AtomicNumber = 102 });
            elements.Insert(119, new Element { Name = "Lr", Classification = "Antínidos", AtomicNumber = 103 });

       
            ViewBag.Lista = elements;

            return View();
        }
    }
}
