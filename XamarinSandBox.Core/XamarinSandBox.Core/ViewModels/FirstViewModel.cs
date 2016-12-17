using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace XamarinSandBox.Core.ViewModels
{
    public class FirstViewModel:MvxViewModel
    {
        public MvxCommand CalcSquareCommand
        {
            get
            {
                return new MvxCommand(async () =>
                {
                    await CalculateSquare();
                });
            }
            
        }
		public MvxCommand CalcSquareRootCommand
		{
			get
			{
				return new MvxCommand(async () =>
				{
					await Task.Run(() => {
						SquareResult = Math.Sqrt(Number);
						LabelText = "SquareRoot of the number";
					});
				});
			}

		}
		private string _labelText;
		public string LabelText
		{
			get { return _labelText;}
			set
			{
				_labelText = value;
				RaisePropertyChanged(() => LabelText);
			}
		}

        private double _number;
        public double Number
        {
            get { return _number;}
            set
            {
                _number = value;
                RaisePropertyChanged(()=>Number);
            }
        }

        private double _squareResult;

        public double SquareResult
        {
            get
            {
                return _squareResult;
            }
            set
            {
                _squareResult = value;
                RaisePropertyChanged(()=>SquareResult);
            }
        }



        private async Task CalculateSquare()
        {
            await Task.Run((() =>
            {
                SquareResult = Number*Number;
                LabelText = "Square of the number";
            }));

        }
    }
}
