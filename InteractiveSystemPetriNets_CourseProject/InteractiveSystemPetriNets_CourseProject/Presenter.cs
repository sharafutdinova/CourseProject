using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

namespace InteractiveSystemPetriNets_CourseProject
{
    partial class Presenter
    {
        View _view = null;
        Model _model = null;
        Provider _provider = null;
        List<Question> _questions = null;
        Question _currQuestion = null;

        public Presenter(View view)
        {
            _view = view;
            _model = new Model();
            _provider = new Provider();
            SubscribeHandlers();
        }

       public void SubscribeHandlers()
        {
            _view.okButtonPressing += view_okButtonPressing;

            _view.saveDialogueMoveButtonPressing += view_saveDialogueMoveButtonPressing;

            _view.openDialogueMenuItemPressing += view_openDialogueMenuItemPressing;

            _view.closeMenuItemPressing += view_closeMenuItemPressing;
        }

       public void view_saveDialogueMoveButtonPressing(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "TXT files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    StreamWriter sw = new StreamWriter(myStream);
                    for (int i = 0; i < _view.Dlist.Items.Count; i++)
                    {
                        sw.WriteLine(_view.Dlist.Items[i].ToString());
                    }
                    sw.Close();
                    myStream.Close();
                }
            }
            else
            {
                MessageBox.Show("Файл диалога не сохранен!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       public void view_okButtonPressing(object sender, EventArgs e)
        {
            if (IsSelectAnswer())
            {
                UpdateView(_view.Alist.SelectedIndex);
            }
            else
            {
                _view.Elist.Items.Add("Open the dialog or ");
                _view.Elist.Items.Add("choose one from the proposed");
            }
        }

       public void view_openDialogueMenuItemPressing(object sender, EventArgs e)
        {
            _questions = _provider.Load();
            
            UpdateView(0);
        }

       public void view_closeMenuItemPressing(object sender, EventArgs e)
        {
            _view.Close();
        }

       public void ClearView()
        {
            _view.Alist.Items.Clear();
        }

       public void UpdateView(int ind)
        {
            if (_currQuestion == null)
            {
                _currQuestion = _model.GetNextQuestion(1, _questions);
            }
            else
            {
                _view.Dlist.Items.Add("Ответ:" + _currQuestion.Answers[ind].AnswerText);
                _currQuestion = _model.GetNextQuestion(_currQuestion.Answers[ind].NextPosition, _questions); // получаем следующий вопрос
            }

            if (_currQuestion != null)//если не находим следующий вопрос, завершаем диалог
            {
                _view.Dlist.Items.Add("Вопрос:" + _currQuestion.Text);

                _view.Dlist.TopIndex = _view.Dlist.Items.Count - 1;
                ClearView();

                foreach (Answer answer in _currQuestion.Answers)
                {
                    _view.Alist.Items.Add(answer.AnswerText);
                }
            }
            else
            {
                _view.Dlist.Items.Add("Работа завершена!");
                _view.Dlist.TopIndex = _view.Dlist.Items.Count - 1;
                ClearView();
            }
        }

       public bool IsSelectAnswer()//проверяем был ли выбран ответ
        {
            if(_view.Alist.SelectedIndex != -1 && _view.Alist.Items.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
