using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootStat
{
    public class Verification
    {
        public Boolean Detail(TextBox nom, TextBox prenom, TextBox adresse,TextBox numero, TextBox dateNaissance, TextBox img) {
            if (!string.IsNullOrWhiteSpace(nom.Text) && !string.IsNullOrWhiteSpace(prenom.Text) && !string.IsNullOrWhiteSpace(adresse.Text) && !string.IsNullOrWhiteSpace(numero.Text) && !string.IsNullOrWhiteSpace(dateNaissance.Text) && !string.IsNullOrWhiteSpace(img.Text))
            {
                return true;
            } else return false;
        }
        public Boolean Morphologie(TextBox taill,TextBox poid) {
            if (!string.IsNullOrWhiteSpace(taill.Text) && !string.IsNullOrWhiteSpace(poid.Text))
            {
                return true;
            }
            else return false;
        }
        public Boolean Physique(TextBox vitesseRe,TextBox vitesseCou, TextBox Cord, TextBox soup, TextBox dist) {
            if (string.IsNullOrWhiteSpace(vitesseRe.Text) || string.IsNullOrWhiteSpace(vitesseCou.Text) || string.IsNullOrWhiteSpace(Cord.Text) || string.IsNullOrWhiteSpace(soup.Text) || string.IsNullOrWhiteSpace(dist.Text))
            {
                
                return false;
            }
            else return true;
        }
        public Boolean Technique(TextBox gengle,TextBox slalome, TextBox gen1,TextBox gen2,TextBox gen3) {
            if (string.IsNullOrWhiteSpace(gengle.Text) || string.IsNullOrWhiteSpace(slalome.Text) || string.IsNullOrWhiteSpace(gen1.Text) || string.IsNullOrWhiteSpace(gen2.Text) || string.IsNullOrWhiteSpace(gen3.Text))
            {
                return false;
            }
            else return true;
        }
        public Boolean Physiologique(TextBox distance) {
            if (!string.IsNullOrWhiteSpace(distance.Text))
            {
                return true;
            }
            else return false;
        }

    }
}
