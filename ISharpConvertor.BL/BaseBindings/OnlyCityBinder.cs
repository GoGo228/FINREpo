﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISharpConvertor.UIModels;
using ISharpConvertor.DAL.Concrate;
using ISharpConvertor.BL.BaseMappers;

namespace ISharpConvertor.BL.BaseBindings
{
    public class OnlyCityBinder
    {
        public List<OnlyCityModel> BindData(string country)
        {
            RepositoryHolder holder = new RepositoryHolder();

            OnlyCityMapper mapper = new OnlyCityMapper();
            var adressRepository = holder.AdressRepository;
            List<OnlyCityModel> resultnewData =
                adressRepository.
                    FetchBy(p=>p.cCountry==country).
                    Select(p => mapper.EntityToUI(p)).Distinct().ToList();

            //return resultnewData.Distinct().ToList();
            return GenerateUnique(resultnewData.ToList()).Distinct().ToList();
        }
        private List<OnlyCityModel> GenerateUnique (List<OnlyCityModel>  lst)
        {
            foreach (var item in lst)
            {
                var listItems = lst.Where(p => p.City == item.City).ToList();
                //lst.RemoveAll(listItems.Skip(1).ToList());
                foreach (var removedItems in listItems.Skip(1))
                {
                    lst.Remove(removedItems);
                }
            }
            return lst;
        }
    }
}
