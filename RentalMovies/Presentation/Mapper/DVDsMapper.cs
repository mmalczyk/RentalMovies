﻿using RentalMovies.Domain.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace RentalMovies.Domain.Tables
{
    public class DVDsTable : DataTableObject<DVD>
    {
        public override void Add(DVD obj)
        {
            throw new NotImplementedException();
        }

        public override void Delete(DVD id)
        {
            throw new NotImplementedException();
        }

        public override void PopulateRow(DVD obj, ref DataRow row, bool isNew)
        {
            throw new NotImplementedException();
        }

        public override DVD RowToDataObject(DataRow row)
        {
            throw new NotImplementedException();
        }
        
        public override DVD Select(string id)
        {
            throw new NotImplementedException();
        }

        public override void Update(DVD obj)
        {
            throw new NotImplementedException();
        }
    }
}
