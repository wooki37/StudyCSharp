using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace ThisIsCSharpExam.Ch._19.TaskParallelExam
{
    class UsingTask
    {
        public void Main(string[] args)
        {
            string srcFile = args[0];

            //Action<object> FileCopyAction = (object state) =>   // 인수를 받음
            //{
            //    string[] paths = (string[])state;
            //    File.Copy(paths[0], paths[1]);

            //    Console.WriteLine("TaskID:[{0}], ThreadID:[{1}], [{2}] was copied to [{3}]",
            //        Task.CurrentId, Thread.CurrentThread.ManagedThreadId, paths[0], paths[1]);
            //};

            // t1 -> 생성자에서 넘겨받은 무명 함수를 비동기로 호출합니다.
            Task t1 = new Task(FileCopyAction, new string[] { srcFile, srcFile + ".copy1" });

            /*
            t2 -> Task의 생성과 기작은 단번에 합니다.
            덤으로 Task가 실행할 Action 대리자도 무명 함수로 바꿔보았습니다.
            */
            Task t2 = Task.Run(() =>
            {
                FileCopyAction(new string[] { srcFile, srcFile + ".copy2" });
            });

            t1.Start();

            // 두 번째 인수는 FileCopyAction의 인수로 상요됩니다.
            Task t3 = new Task(FileCopyAction, new string[] { srcFile, srcFile + ".copy3" });

            /*
            Task는 코드의 비동기 실행을 위한 Start() 메소드뿐 아니라 동기 실행을 위한
            RunSynchronously() 메소드도 제공합니다.
            이 메소드는 실행이 끝나야 반환지만, 나쁜 습관을 방지하기 위해 Wait()는 호출해주는 것이 좋습니다.
            */
            t3.RunSynchronously();

            // t1, t2, t3 비동기 호출이 완료될 때까지 기다립니다.
            t1.Wait();
            t2.Wait();
            t3.Wait();

            Console.ReadLine();
        }

        // FileCopyAction 메소드를 따로 분리
        private void FileCopyAction(object state)
        {
            string[] paths = (string[])state;
            File.Copy(paths[0], paths[1]);

            Console.WriteLine("TaskID:[{0}], ThreadID:[{1}], [{2}] was copied to [{3}]",
                Task.CurrentId, Thread.CurrentThread.ManagedThreadId, paths[0], paths[1]);

        }
    }
}
