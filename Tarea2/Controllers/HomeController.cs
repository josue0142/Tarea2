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


            List<Element> elements = new List<Element> {
                new Element { Name = "H", Classification = "NoMetales",AtomicNumber = 1 },
                new Element { Name = "He", Classification = "NoMetales",AtomicNumber = 2 },
                new Element { Name = "Li", Classification = "NoMetales",AtomicNumber = 3 },
                new Element { Name = "Be", Classification = "NoMetales",AtomicNumber = 4 },
                new Element { Name = "B", Classification = "NoMetales",AtomicNumber = 5 },
                new Element { Name = "C", Classification = "NoMetales",AtomicNumber = 6 },
                new Element { Name = "N", Classification = "NoMetales",AtomicNumber = 7 },
                new Element { Name = "O", Classification = "NoMetales",AtomicNumber = 8 },
                new Element { Name = "F", Classification = "NoMetales",AtomicNumber = 9 },
                new Element { Name = "Ne", Classification = "NoMetales",AtomicNumber = 10 },
                new Element { Name = "Na", Classification = "NoMetales",AtomicNumber = 11 },
                new Element { Name = "Mg", Classification = "NoMetales",AtomicNumber = 12 },
                new Element { Name = "Al", Classification = "NoMetales",AtomicNumber = 13 },
                new Element { Name = "Si", Classification = "NoMetales",AtomicNumber = 14 },
                new Element { Name = "P", Classification = "NoMetales",AtomicNumber = 15 },
                new Element { Name = "S", Classification = "NoMetales",AtomicNumber = 16 },
                new Element { Name = "Cl", Classification = "NoMetales",AtomicNumber = 17 },
                new Element { Name = "Ar", Classification = "NoMetales",AtomicNumber = 18 },
                new Element { Name = "K", Classification = "NoMetales",AtomicNumber = 19 },
                new Element { Name = "Ca", Classification = "NoMetales",AtomicNumber = 20 }, 
                new Element { Name = "Sc", Classification = "NoMetales",AtomicNumber = 21 },
                new Element { Name = "Ti", Classification = "NoMetales",AtomicNumber = 22 },
                new Element { Name = "V", Classification = "NoMetales",AtomicNumber = 23 },
                new Element { Name = "Cr", Classification = "NoMetales",AtomicNumber = 24 },
                new Element { Name = "Mn", Classification = "NoMetales",AtomicNumber = 25 },
                new Element { Name = "Fe", Classification = "NoMetales",AtomicNumber = 26 },
                new Element { Name = "Co", Classification = "NoMetales",AtomicNumber = 27 },
                new Element { Name = "Ni", Classification = "NoMetales",AtomicNumber = 28 },
                new Element { Name = "Cu", Classification = "NoMetales",AtomicNumber = 29 }, 
                new Element { Name = "Zn", Classification = "NoMetales",AtomicNumber = 30 }, 
                new Element { Name = "Ga", Classification = "NoMetales",AtomicNumber = 31 },
                new Element { Name = "Ge", Classification = "NoMetales",AtomicNumber = 32 },
                new Element { Name = "As", Classification = "NoMetales",AtomicNumber = 33 }, 
                new Element { Name = "Se", Classification = "NoMetales",AtomicNumber = 34 }, 
                new Element { Name = "Br", Classification = "NoMetales",AtomicNumber = 35 }, 
                new Element { Name = "Kr", Classification = "NoMetales",AtomicNumber = 36 }, 
                new Element { Name = "Rb", Classification = "NoMetales",AtomicNumber = 37 }, 
                new Element { Name = "Sr", Classification = "NoMetales",AtomicNumber = 38 }, 
                new Element { Name = "Y", Classification = "NoMetales",AtomicNumber = 39 }, 
                new Element { Name = "Zr", Classification = "NoMetales",AtomicNumber = 40 }, 
                new Element { Name = "Nb", Classification = "NoMetales",AtomicNumber = 41 }, 
                new Element { Name = "Mo", Classification = "NoMetales",AtomicNumber = 42 }, 
                new Element { Name = "Tc", Classification = "NoMetales",AtomicNumber = 43 }, 
                new Element { Name = "Ru", Classification = "NoMetales",AtomicNumber = 44 }, 
                new Element { Name = "Rh", Classification = "NoMetales",AtomicNumber = 45 }, 
                new Element { Name = "Pd", Classification = "NoMetales",AtomicNumber = 46 },
                new Element { Name = "Ag", Classification = "NoMetales",AtomicNumber = 47 },
                new Element { Name = "Cd", Classification = "NoMetales",AtomicNumber = 48 }, 
                new Element { Name = "In", Classification = "NoMetales",AtomicNumber = 49 }, 
                new Element { Name = "Sn", Classification = "NoMetales",AtomicNumber = 50 },
                new Element { Name = "Sb", Classification = "NoMetales",AtomicNumber = 51 }, 
                new Element { Name = "Te", Classification = "NoMetales",AtomicNumber = 52 }, 
                new Element { Name = "I", Classification = "NoMetales",AtomicNumber = 53 }, 
                new Element { Name = "Xe", Classification = "NoMetales",AtomicNumber = 54 }, 
                new Element { Name = "Cs", Classification = "NoMetales",AtomicNumber = 55 },
                new Element { Name = "Ba", Classification = "NoMetales",AtomicNumber = 56 },
                new Element { Name = "La-Lu", Classification = "NoMetales",AtomicNumber = 57-71 }, 
                new Element { Name = "La", Classification = "NoMetales",AtomicNumber = 57 }, 
                new Element { Name = "Ce", Classification = "NoMetales",AtomicNumber = 58 }, 
                new Element { Name = "Pr", Classification = "NoMetales",AtomicNumber = 59 }, 
                new Element { Name = "Nd", Classification = "NoMetales",AtomicNumber = 60 }, 
                new Element { Name = "Pm", Classification = "NoMetales",AtomicNumber = 61 }, 
                new Element { Name = "Sm", Classification = "NoMetales",AtomicNumber = 62 }, 
                new Element { Name = "Eu", Classification = "NoMetales",AtomicNumber = 63 }, 
                new Element { Name = "Gd", Classification = "NoMetales",AtomicNumber = 64 }, 
                new Element { Name = "Tb", Classification = "NoMetales",AtomicNumber = 65 }, 
                new Element { Name = "Dy", Classification = "NoMetales",AtomicNumber = 66 }, 
                new Element { Name = "Ho", Classification = "NoMetales",AtomicNumber = 67 },
                new Element { Name = "Er", Classification = "NoMetales",AtomicNumber = 68 },
                new Element { Name = "Tm", Classification = "NoMetales",AtomicNumber = 69 }, 
                new Element { Name = "Yb", Classification = "NoMetales",AtomicNumber = 70 }, 
                new Element { Name = "Lu", Classification = "NoMetales",AtomicNumber = 71 }, 
                new Element { Name = "Hf", Classification = "NoMetales",AtomicNumber = 72 }, 
                new Element { Name = "Ta", Classification = "NoMetales",AtomicNumber = 73 }, 
                new Element { Name = "W", Classification = "NoMetales",AtomicNumber = 74 }, 
                new Element { Name = "Re", Classification = "NoMetales",AtomicNumber = 75 }, 
                new Element { Name = "Os", Classification = "NoMetales",AtomicNumber = 76 }, 
                new Element { Name = "Ir", Classification = "NoMetales",AtomicNumber = 77 }, 
                new Element { Name = "Pt", Classification = "NoMetales",AtomicNumber = 78 }, 
                new Element { Name = "Au", Classification = "NoMetales",AtomicNumber = 79 }, 
                new Element { Name = "Hg", Classification = "NoMetales",AtomicNumber = 80 }, 
                new Element { Name = "Tl", Classification = "NoMetales",AtomicNumber = 81 },
                new Element { Name = "Pb", Classification = "NoMetales",AtomicNumber = 82 },
                new Element { Name = "Bi", Classification = "NoMetales",AtomicNumber = 82 },
                new Element { Name = "Po", Classification = "NoMetales",AtomicNumber = 84 },
                new Element { Name = "At", Classification = "NoMetales",AtomicNumber = 85 },
                new Element { Name = "Rn", Classification = "NoMetales",AtomicNumber = 86 }, 
                new Element { Name = "Fr", Classification = "NoMetales",AtomicNumber = 87 }, 
                new Element { Name = "Ra", Classification = "NoMetales",AtomicNumber = 88 },
                new Element { Name = "Ac-Lr", Classification = "NoMetales",AtomicNumber = 89-103 },
                new Element { Name = "Ac", Classification = "NoMetales",AtomicNumber = 89 }, 
                new Element { Name = "Th", Classification = "NoMetales",AtomicNumber = 90 }, 
                new Element { Name = "Pa", Classification = "NoMetales",AtomicNumber = 91 }, 
                new Element { Name = "U", Classification = "NoMetales",AtomicNumber = 92 }, 
                new Element { Name = "Np", Classification = "NoMetales",AtomicNumber = 93 },
                new Element { Name = "Pu", Classification = "NoMetales",AtomicNumber = 94 }, 
                new Element { Name = "Am", Classification = "NoMetales",AtomicNumber = 95 },
                new Element { Name = "Cm", Classification = "NoMetales",AtomicNumber = 96 },
                new Element { Name = "Bk", Classification = "NoMetales",AtomicNumber = 97 },
                new Element { Name = "Cf", Classification = "NoMetales",AtomicNumber = 98 },
                new Element { Name = "Es", Classification = "NoMetales",AtomicNumber = 99 },
                new Element { Name = "Fm", Classification = "NoMetales",AtomicNumber = 100 },
                new Element { Name = "Md", Classification = "NoMetales",AtomicNumber = 101 },
                new Element { Name = "No", Classification = "NoMetales",AtomicNumber = 102 },
                new Element { Name = "Lr", Classification = "NoMetales",AtomicNumber = 103 },
                new Element { Name = "Rf", Classification = "NoMetales",AtomicNumber = 104 },
                new Element { Name = "Db", Classification = "NoMetales",AtomicNumber = 105 },
                new Element { Name = "Sg", Classification = "NoMetales",AtomicNumber = 106 }, 
                new Element { Name = "Bh", Classification = "NoMetales",AtomicNumber = 107 }, 
                new Element { Name = "Hs", Classification = "NoMetales",AtomicNumber = 108 }, 
                new Element { Name = "Mt", Classification = "NoMetales",AtomicNumber = 109 },
                new Element { Name = "Ds", Classification = "NoMetales",AtomicNumber = 110 },
                new Element { Name = "Rg", Classification = "NoMetales",AtomicNumber = 111 },
                new Element { Name = "Cn", Classification = "NoMetales",AtomicNumber = 112 },
                new Element { Name = "Nh", Classification = "NoMetales",AtomicNumber = 113 },
                new Element { Name = "Fl", Classification = "NoMetales",AtomicNumber = 114 },
                new Element { Name = "Mc", Classification = "NoMetales",AtomicNumber = 115 },
                new Element { Name = "Lv", Classification = "NoMetales",AtomicNumber = 116 },
                new Element { Name = "Ts", Classification = "NoMetales",AtomicNumber = 117 },
                new Element { Name = "Og", Classification = "NoMetales",AtomicNumber = 118 },
            };

            return View();
        }



        /*public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/
    }
}
