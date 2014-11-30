﻿using System;
using System.Linq;
using GraveyardManagement.Model.EntityFramework;

namespace GraveyardManagement.Model.ModelCetatean
{
    public class ModelCetatean
    {
        private readonly NecropolisEntities _entities;

        public ModelCetatean(NecropolisEntities entities)
        {
            _entities = entities;
        }

        public void AdaugaCetatean(string cnp, string nume, string prenume, string localitate, string strada, string numar, string alteInformatii)
        {
            //ceva verificari: daca localitatea exista, daca strada exista
            var existaLocalitatea = _entities.Localitate.FirstOrDefault(loc => loc.nume == localitate);

            if (existaLocalitatea == null)
            {
                throw new Exception(string.Format("Localitatea {0} nu exista printre localitatile inregistrate.", localitate));
            }

            var existaStrada = _entities.Strada.FirstOrDefault(str => str.nume == strada && str.localitateId == existaLocalitatea.id);

            if (existaStrada == null)
            {
                throw new Exception(string.Format("Strada {0} nu exista printre strazile inregistrate.", strada));
            }

            var domiciliuNou = new Domiciliu
            {
                stradaId = existaStrada.id,
                numar = numar,
                alteInformatii = alteInformatii
            };

            _entities.Domiciliu.Add(domiciliuNou);

            _entities.Persoana.Add(new Persoana
            {
                cnp = cnp,
                nume = nume, 
                prenume = prenume,
                domiciliuId = domiciliuNou.id
            });

            _entities.SaveChanges();
        }

        public void ActualizeazaCetatean(string cnp, string numeNou, string prenumeNou, string localitateNoua, string stradaNoua, string numarNou,
            string alteInformatiiNoi)
        {
            var cetateanDb = _entities.Persoana.FirstOrDefault(p => p.cnp == cnp);

            if (cetateanDb == null)
            {
                throw new Exception(string.Format("Cetateanul cu CNP-ul: {0} nu exista!", cnp));
            }

            var domiciliuDb = _entities.Domiciliu.FirstOrDefault(d => d.id == cetateanDb.domiciliuId);

            if (domiciliuDb == null)
            {
                throw new Exception(string.Format("Cetateanul {0} {1} cu CNP-ul: {2} nu are inregistrat un domiciliu. Exista posibilitatea ca acesta sa fie decedat.", cetateanDb.nume, cetateanDb.prenume, cnp));
            }

            var localitateDb = _entities.Localitate.FirstOrDefault(loc => loc.nume == localitateNoua);

            if (localitateDb == null)
            {
                throw new Exception(string.Format("Localitatea {0} nu exista printre localitatile inregistrate.", localitateNoua));
            }

            var stradaDb = _entities.Strada.FirstOrDefault(str => str.nume == stradaNoua && str.localitateId == localitateDb.id);

            if (stradaDb == null)
            {
                throw new Exception(string.Format("Strada {0} nu exista printre strazile inregistrate.", stradaNoua));
            }

            //introdu noile informatii in baza de date
            stradaDb.localitateId = localitateDb.id;

            domiciliuDb.numar = numarNou;
            domiciliuDb.stradaId = stradaDb.id;
            domiciliuDb.alteInformatii = alteInformatiiNoi;

            cetateanDb.nume = numeNou;
            cetateanDb.prenume = prenumeNou;

            _entities.SaveChanges();
        }

        public CetateanDto CautaCetatean(string cnp)
        {
            var cetateanDb = _entities.Persoana.FirstOrDefault(p => p.cnp == cnp && p.domiciliuId != null);

            if (cetateanDb == null)
            {
                throw new Exception(string.Format("Cetateanul cu CNP-ul: {0} nu a fost gasit!", cnp));
            }

            var domiciliuCetateanDb = _entities.Domiciliu.FirstOrDefault(d => d.id == cetateanDb.domiciliuId);

            if (domiciliuCetateanDb == null)
            {
                throw new Exception(string.Format("Cetateanul {0} {1} cu CNP-ul: {2} nu are inregistrat un domiciliu. Exista posibilitatea ca acesta sa fie decedat.", cetateanDb.nume, cetateanDb.prenume, cnp));
            }

            var stradaCetateanDb = _entities.Strada.FirstOrDefault(s => s.id == domiciliuCetateanDb.stradaId);

            if (stradaCetateanDb == null)
            {
                throw new Exception(string.Format("Domiciliul cetateanului {0} {1} cu CNP-ul {2} nu este valid.", cetateanDb.nume, cetateanDb.prenume, cnp));
            }

            var localitateCetateanDb = _entities.Localitate.FirstOrDefault(l => l.id == stradaCetateanDb.localitateId);

            if (localitateCetateanDb == null)
            {
                throw new Exception(string.Format("Domiciliul cetateanului {0} {1} cu CNP-ul {2} nu este valid.", cetateanDb.nume, cetateanDb.prenume, cnp));
            }

            return new CetateanDto
            {
                Cnp = cnp,
                Nume = cetateanDb.nume,
                Prenume = cetateanDb.prenume,
                Localitate = localitateCetateanDb.nume,
                Strada = stradaCetateanDb.nume,
                Numar = domiciliuCetateanDb.numar,
                AlteInformatii = domiciliuCetateanDb.alteInformatii
            };
        }
    }
}
