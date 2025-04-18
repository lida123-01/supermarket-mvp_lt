using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using supermarket_mvp_lt.Models;
using supermarket_mvp_lt.Views;
using supermarket_mvp_lt._Repositories;

namespace supermarket_mvp_lt.Presenters
{
    internal class MainPresenter
    {
        private readonly IMainView mainView;
        private readonly string sqlConnectionString;
    

        public MainPresenter(IMainView mainView, string sqlConnectionString)
            {
                this.mainView = mainView;
                this.sqlConnectionString = sqlConnectionString;

                this.mainView.ShowPayModeView += ShowPayModeView;
            }

        
        private void ShowPayModeView(object? sender, EventArgs e)
        {

            IPayModeView view = PayModeView.GetInstance();
            IPayModeRepository repository = new PayModeRepository(sqlConnectionString);
            new PayModePresenter(view, repository);
        }
    }
    }
