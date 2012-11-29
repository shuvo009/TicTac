using Android.App;
using Android.OS;
using Android.Widget;

namespace TicTac
{
    [Activity(Label = "TicTac", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : Activity
    {
        private const int GameOverMenu = 1;
        private const int WinMenu = 0;
        private readonly EnTicTac[,] _enTicTacs = new EnTicTac[3,3];
        private readonly ImageButton[,] _imageButtons = new ImageButton[3,3];
        private int _counter;
        private bool _isTic;
        private bool _isMatch;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);
            _imageButtons[0, 0] = FindViewById<ImageButton>(Resource.Id.ImgButton00);
            _imageButtons[0, 0].Click += (o, e) =>
                                             {
                                                 _imageButtons[0, 0].Clickable = false;
                                                 if (_isTic)
                                                 {
                                                     _imageButtons[0, 0].SetBackgroundResource(Resource.Drawable.tack);
                                                     _enTicTacs[0, 0] = EnTicTac.Tic;
                                                 }
                                                 else
                                                 {
                                                     _imageButtons[0, 0].SetBackgroundResource(Resource.Drawable.tick);
                                                     _enTicTacs[0, 0] = EnTicTac.Tac;
                                                 }
                                                 _isTic = !_isTic;
                                                _isMatch = CheckRow(0);
                                                _isMatch=  CheckCloumn(0)||_isMatch;
                                                _isMatch= CheckLeftCorner()||_isMatch;
                                                 if(_isMatch)
                                                 {
                                                     ShowDialog(WinMenu);
                                                     return;
                                                 }
                                                 GameOverCheck();
                                             };
            _imageButtons[0, 1] = FindViewById<ImageButton>(Resource.Id.ImgButton01);
            _imageButtons[0, 1].Click += (o, e) =>
                                             {
                                                 _imageButtons[0, 1].Clickable = false;
                                                 if (_isTic)
                                                 {
                                                     _imageButtons[0, 1].SetBackgroundResource(Resource.Drawable.tack);
                                                     _enTicTacs[0, 1] = EnTicTac.Tic;
                                                 }
                                                 else
                                                 {
                                                     _imageButtons[0, 1].SetBackgroundResource(Resource.Drawable.tick);
                                                     _enTicTacs[0, 1] = EnTicTac.Tac;
                                                 }
                                                 _isTic = !_isTic;
                                                 _isMatch = CheckRow(0);
                                                 _isMatch= CheckCloumn(1)||_isMatch;
                                                 if (_isMatch)
                                                 {
                                                    ShowDialog(WinMenu);
                                                    return;
                                                 }
                                                 GameOverCheck();
                                             };
            _imageButtons[0, 2] = FindViewById<ImageButton>(Resource.Id.ImgButton02);
            _imageButtons[0, 2].Click += (o, e) =>
                                             {
                                                 _imageButtons[0, 2].Clickable = false;
                                                 if (_isTic)
                                                 {
                                                     _imageButtons[0, 2].SetBackgroundResource(Resource.Drawable.tack);
                                                     _enTicTacs[0, 2] = EnTicTac.Tic;
                                                 }
                                                 else
                                                 {
                                                     _imageButtons[0, 2].SetBackgroundResource(Resource.Drawable.tick);
                                                     _enTicTacs[0, 2] = EnTicTac.Tac;
                                                 }
                                                 _isTic = !_isTic;
                                                 _isMatch = CheckRow(0);
                                                 _isMatch = CheckCloumn(2) || _isMatch;
                                                 _isMatch=CheckRightCorner()||_isMatch;
                                                 if (_isMatch)
                                                 {
                                                     ShowDialog(WinMenu);
                                                     return;
                                                 }
                                                 GameOverCheck();
                                             };
            _imageButtons[1, 0] = FindViewById<ImageButton>(Resource.Id.ImgButton10);
            _imageButtons[1, 0].Click += (o, e) =>
                                             {
                                                 _imageButtons[1, 0].Clickable = false;
                                                 if (_isTic)
                                                 {
                                                     _imageButtons[1, 0].SetBackgroundResource(Resource.Drawable.tack);
                                                     _enTicTacs[1, 0] = EnTicTac.Tic;
                                                 }
                                                 else
                                                 {
                                                     _imageButtons[1, 0].SetBackgroundResource(Resource.Drawable.tick);
                                                     _enTicTacs[1, 0] = EnTicTac.Tac;
                                                 }
                                                 _isTic = !_isTic;
                                                 _isMatch=CheckRow(1);
                                                 _isMatch=CheckCloumn(0)||_isMatch;
                                                 if (_isMatch)
                                                 {
                                                     ShowDialog(WinMenu);
                                                     return;
                                                 }
                                                 GameOverCheck();
                                             };
            _imageButtons[1, 1] = FindViewById<ImageButton>(Resource.Id.ImgButton11);
            _imageButtons[1, 1].Click += (o, e) =>
                                             {
                                                 _imageButtons[1, 1].Clickable = false;
                                                 if (_isTic)
                                                 {
                                                     _imageButtons[1, 1].SetBackgroundResource(Resource.Drawable.tack);
                                                     _enTicTacs[1, 1] = EnTicTac.Tic;
                                                 }
                                                 else
                                                 {
                                                     _imageButtons[1, 1].SetBackgroundResource(Resource.Drawable.tick);
                                                     _enTicTacs[1, 1] = EnTicTac.Tac;
                                                 }
                                                 _isTic = !_isTic;
                                                 _isMatch=CheckRow(1);
                                                 _isMatch=CheckCloumn(1)||_isMatch;
                                                 _isMatch=CheckLeftCorner()||_isMatch;
                                                 _isMatch=CheckRightCorner()||_isMatch;
                                                 if (_isMatch)
                                                 {
                                                     ShowDialog(WinMenu);
                                                     return;
                                                 }
                                                 GameOverCheck();
                                             };
            _imageButtons[1, 2] = FindViewById<ImageButton>(Resource.Id.ImgButton12);
            _imageButtons[1, 2].Click += (o, e) =>
                                             {
                                                 _imageButtons[1, 2].Clickable = false;
                                                 if (_isTic)
                                                 {
                                                     _imageButtons[1, 2].SetBackgroundResource(Resource.Drawable.tack);
                                                     _enTicTacs[1, 2] = EnTicTac.Tic;
                                                 }
                                                 else
                                                 {
                                                     _imageButtons[1, 2].SetBackgroundResource(Resource.Drawable.tick);
                                                     _enTicTacs[1, 2] = EnTicTac.Tac;
                                                 }
                                                 _isTic = !_isTic;
                                                 _isMatch=CheckRow(1);
                                                 _isMatch=CheckCloumn(2)||_isMatch;
                                                 if (_isMatch)
                                                 {
                                                     ShowDialog(WinMenu);
                                                     return;
                                                 }
                                                 GameOverCheck();
                                             };
            _imageButtons[2, 0] = FindViewById<ImageButton>(Resource.Id.ImgButton20);
            _imageButtons[2, 0].Click += (o, e) =>
                                             {
                                                 _imageButtons[2, 0].Clickable = false;
                                                 if (_isTic)
                                                 {
                                                     _imageButtons[2, 0].SetBackgroundResource(Resource.Drawable.tack);
                                                     _enTicTacs[2, 0] = EnTicTac.Tic;
                                                 }
                                                 else
                                                 {
                                                     _imageButtons[2, 0].SetBackgroundResource(Resource.Drawable.tick);
                                                     _enTicTacs[2, 0] = EnTicTac.Tac;
                                                 }
                                                 _isTic = !_isTic;
                                                 _isMatch= CheckRow(2);
                                                _isMatch= CheckCloumn(0)||_isMatch;
                                                _isMatch= CheckRightCorner()||_isMatch;
                                                if (_isMatch)
                                                {
                                                    ShowDialog(WinMenu);
                                                    return;
                                                }
                                                 GameOverCheck();
                                             };
            _imageButtons[2, 1] = FindViewById<ImageButton>(Resource.Id.ImgButton21);
            _imageButtons[2, 1].Click += (o, e) =>
                                             {
                                                 _imageButtons[2, 1].Clickable = false;
                                                 if (_isTic)
                                                 {
                                                     _imageButtons[2, 1].SetBackgroundResource(Resource.Drawable.tack);
                                                     _enTicTacs[2, 1] = EnTicTac.Tic;
                                                 }
                                                 else
                                                 {
                                                     _imageButtons[2, 1].SetBackgroundResource(Resource.Drawable.tick);
                                                     _enTicTacs[2, 1] = EnTicTac.Tac;
                                                 }
                                                 _isTic = !_isTic;
                                                 _isMatch=CheckRow(2);
                                                 _isMatch=CheckCloumn(1)||_isMatch;
                                                 if (_isMatch)
                                                 {
                                                     ShowDialog(WinMenu);
                                                     return;
                                                 }
                                                 GameOverCheck();
                                             };
            _imageButtons[2, 2] = FindViewById<ImageButton>(Resource.Id.ImgButton22);
            _imageButtons[2, 2].Click += (o, e) =>
                                             {
                                                 _imageButtons[2, 2].Clickable = false;
                                                 if (_isTic)
                                                 {
                                                     _imageButtons[2, 2].SetBackgroundResource(Resource.Drawable.tack);
                                                     _enTicTacs[2, 2] = EnTicTac.Tic;
                                                 }
                                                 else
                                                 {
                                                     _imageButtons[2, 2].SetBackgroundResource(Resource.Drawable.tick);
                                                     _enTicTacs[2, 2] = EnTicTac.Tac;
                                                 }
                                                 _isTic = !_isTic;
                                                 _isMatch=CheckRow(2);
                                                 _isMatch=CheckCloumn(2)||_isMatch;
                                                 _isMatch=CheckLeftCorner()||_isMatch;
                                                 if (_isMatch)
                                                 {
                                                     ShowDialog(WinMenu);
                                                     return;
                                                 }
                                                 GameOverCheck();
                                             };
        }


        private bool CheckCloumn(int start)
        {
            EnTicTac tac = _enTicTacs[0, start];
            for (int i = 1; i < 3; i++)
            {
                if (tac == _enTicTacs[i, start])
                {
                    tac = _enTicTacs[i, start];
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        private bool CheckLeftCorner()
        {
            EnTicTac tac = _enTicTacs[0, 0];
            for (int i = 1,j=1; i < 3; i++,j++)
            {
                if (tac == _enTicTacs[i, j])
                {
                    tac = _enTicTacs[i, j];
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        private bool CheckRightCorner()
        {
            EnTicTac tac = _enTicTacs[0, 2];
            for (int i = 1,j=1; i < 3; i++,j--)
            {
                if (tac == _enTicTacs[i, j])
                {
                    tac = _enTicTacs[i, j];
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        private bool CheckRow(int start)
        {
            EnTicTac tac = _enTicTacs[start, 0];
            for (int i = 1; i < 3; i++)
            {
                if (tac == _enTicTacs[start, i])
                {
                    tac = _enTicTacs[start, i];
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        private void GameOverCheck()
        {
            _counter++;
            if (_counter == 9)
            {
                ShowDialog(GameOverMenu);
            }
        }

        private void NewGame()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    _imageButtons[i, j].SetBackgroundResource(Android.Resource.Drawable.ButtonDefault);
                    _imageButtons[i, j].Clickable = true;
                    _enTicTacs[i, j] = EnTicTac.Non;
                }
            }
            _counter = 0;
            _isTic = true;
        }

        protected override Dialog OnCreateDialog(int id)
        {
            var builder = new AlertDialog.Builder(this);
            switch (id)
            {
                case WinMenu:
                    {
                        return builder.SetTitle("TicTac")
                            .SetMessage("You Win !\n Do you want restart?")
                            .SetCancelable(false)
                            .SetPositiveButton("Yes", (o, e) => NewGame())
                            .SetNegativeButton("No", (o, e) => Finish())
                            .Create();
                    }
                case GameOverMenu:
                    {
                        return builder.SetTitle("TicTac")
                            .SetMessage("Game Over !\n Do you want restart?")
                            .SetCancelable(false)
                            .SetPositiveButton("Yes", (o, e) => NewGame())
                            .SetNegativeButton("No",(o,e)=> Finish())
                            .Create();
                    }
            }
            return null;
        }

        public override bool OnCreateOptionsMenu(Android.Views.IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.OptionalMenu,menu);
            return true;
        }

        public override bool OnMenuItemSelected(int featureId, Android.Views.IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.menu_new:
                    NewGame();
                    return true;
                case Resource.Id.menu_close:
                    Finish();
                    return true;
                default:
                     return base.OnMenuItemSelected(featureId, item);
            }
           
        }

        protected override void OnDestroy()
        {
            Finish();
            base.OnDestroy();
        }

        #region Nested type: EnTicTac

        private enum EnTicTac
        {
            Non,
            Tic,
            Tac
        }

        #endregion
    }
}