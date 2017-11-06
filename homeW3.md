
# Home Work Three

### Install and use Visual Studio
+ I had installed Visual Studio at the beginning of the term. Thus I had 
this portion finished with before I had started.

### Learn C#
+ This was an enjoyable language as it is very close to Java.

+ The construct of making all of my classes in one "namespace" seemed the most resonable to me
because I wouldn't have to continue reusing my "using" statements, after all when working on a 
project You tend to need the same librarys over and over again. I saw this as an improvement on 
Java.

### Write a moderately complex C# console program using "C-sharpese"
+ The program ran as it was suposed to. Just as well as the Java app. if not better.

### Continue to hone Git skills
+ I give the following as proof for honing my "git" skills.
	```shell
	nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (master)
	$ git branch hw3

	nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (master)
	$ git checkout hw3
	Switched to branch 'hw3'

	nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (hw3)
	$ git add .

	nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (hw3)
	$ git commit -m "starting the set up for hw3"
	On branch hw3
	nothing to commit, working tree clean

	nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (hw3)
	$ ls
	_config.yml  homeW1.md  HW1/  HW2/  HW3/  index.md

	nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (hw3)
	$ git remote
	hw1pages

	nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (hw3)
	$ git push hw1pages hw3
	Total 0 (delta 0), reused 0 (delta 0)
	To https://github.com/nastark519/nastark519.github.io.git
	 * [new branch]      hw3 -> hw3

	nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (hw3)
	$ git add .

	nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (hw3)
	$ git status
	On branch hw3
	Changes to be committed:
	  (use "git reset HEAD <file>..." to unstage)

			new file:   .gitignore
			new file:   HW3/homeWork3/homeWork3.sln
			new file:   HW3/homeWork3/homeWork3/App.config
			new file:   HW3/homeWork3/homeWork3/Program.cs
			new file:   HW3/homeWork3/homeWork3/Properties/AssemblyInfo.cs
			new file:   HW3/homeWork3/homeWork3/homeWork3.csproj


	nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (hw3)
	$ git commit -m "starting my new C# concole app. also added a gitignore."
	[hw3 dbd713c] starting my new C# concole app. also added a gitignore.
	 6 files changed, 395 insertions(+)
	 create mode 100644 .gitignore
	 create mode 100644 HW3/homeWork3/homeWork3.sln
	 create mode 100644 HW3/homeWork3/homeWork3/App.config
	 create mode 100644 HW3/homeWork3/homeWork3/Program.cs
	 create mode 100644 HW3/homeWork3/homeWork3/Properties/AssemblyInfo.cs
	 create mode 100644 HW3/homeWork3/homeWork3/homeWork3.csproj

	nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (hw3)
	$ git push hw1pages hw3
	Counting objects: 12, done.
	Delta compression using up to 4 threads.
	Compressing objects: 100% (10/10), done.
	Writing objects: 100% (12/12), 4.74 KiB | 0 bytes/s, done.
	Total 12 (delta 1), reused 0 (delta 0)
	remote: Resolving deltas: 100% (1/1), completed with 1 local object.
	To https://github.com/nastark519/nastark519.github.io.git
	   611a400..dbd713c  hw3 -> hw3

	nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (hw3)
	$ git add .

	nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (hw3)
	$ git commit -m "I have finished my main method in my Calculator class and am no                                                                                            w working on my DoCalc methon and EvaluatePostFixInput method."
	[hw3 d481176] I have finished my main method in my Calculator class and am now w                                                                                            orking on my DoCalc methon and EvaluatePostFixInput method.
	 1 file changed, 54 insertions(+), 1 deletion(-)

	nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (hw3)
	$ git push hw1pages hw3
	Counting objects: 6, done.
	Delta compression using up to 4 threads.
	Compressing objects: 100% (5/5), done.
	Writing objects: 100% (6/6), 1.12 KiB | 0 bytes/s, done.
	Total 6 (delta 2), reused 0 (delta 0)
	remote: Resolving deltas: 100% (2/2), completed with 2 local objects.
	To https://github.com/nastark519/nastark519.github.io.git
	   dbd713c..d481176  hw3 -> hw3

	nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (hw3)
	$ git add .

	nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (hw3)
	$ git status
	On branch hw3
	Changes to be committed:
	  (use "git reset HEAD <file>..." to unstage)

			modified:   HW3/homeWork3/homeWork3/Program.cs


	nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (hw3)
	$ git commit -m "Starting on my interface the commenting is the bigest pain in t                                                                                            he butt."
	[hw3 205b175] Starting on my interface the commenting is the bigest pain in the                                                                                             butt.
	 1 file changed, 27 insertions(+), 1 deletion(-)

	nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (hw3)
	$ git push hw1pages hw3
	Counting objects: 6, done.
	Delta compression using up to 4 threads.
	Compressing objects: 100% (5/5), done.
	Writing objects: 100% (6/6), 1.08 KiB | 0 bytes/s, done.
	Total 6 (delta 3), reused 0 (delta 0)
	remote: Resolving deltas: 100% (3/3), completed with 3 local objects.
	To https://github.com/nastark519/nastark519.github.io.git
	   d481176..205b175  hw3 -> hw3

	nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (hw3)
	$ git add .

	nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (hw3)
	$ git commit -m "continuing with the interface. It is late and time to sleep."                                                                                              [hw3 cd1d487] continuing with the interface. It is late and time to sleep.
	 1 file changed, 10 insertions(+), 1 deletion(-)

	nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (hw3)
	$ git push hw1pages hw3
	Counting objects: 6, done.
	Delta compression using up to 4 threads.
	Compressing objects: 100% (5/5), done.
	Writing objects: 100% (6/6), 720 bytes | 0 bytes/s, done.
	Total 6 (delta 3), reused 0 (delta 0)
	remote: Resolving deltas: 100% (3/3), completed with 3 local objects.
	To https://github.com/nastark519/nastark519.github.io.git
	   205b175..cd1d487  hw3 -> hw3

	nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (hw3)
	$ git add .

	nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (hw3)
	$ git commit -m "Continuing on my Node class."
	[hw3 e78c84c] Continuing on my Node class.
	 1 file changed, 75 insertions(+)

	nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (hw3)
	$ git add .

	nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (hw3)
	$ git commit -m "finished my Node class using get; and set;."
	[hw3 29b65d5] finished my Node class using get; and set;.
	 1 file changed, 3 insertions(+), 3 deletions(-)

	nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (hw3)
	$ git push hw1pages hw3
	Counting objects: 12, done.
	Delta compression using up to 4 threads.
	Compressing objects: 100% (10/10), done.
	Writing objects: 100% (12/12), 1.88 KiB | 0 bytes/s, done.
	Total 12 (delta 6), reused 0 (delta 0)
	remote: Resolving deltas: 100% (6/6), completed with 3 local objects.
	To https://github.com/nastark519/nastark519.github.io.git
	   cd1d487..29b65d5  hw3 -> hw3

	nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (hw3)
	$ git add .

	nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (hw3)
	$ git commit -m "totally forgot to do the DOOperation method. Starting on that n                                                                                            ow."
	[hw3 ce10910] totally forgot to do the DOOperation method. Starting on that now.
	 1 file changed, 111 insertions(+), 9 deletions(-)

	nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (hw3)
	$ git push hw1pages hw3
	Counting objects: 6, done.
	Delta compression using up to 4 threads.
	Compressing objects: 100% (5/5), done.
	Writing objects: 100% (6/6), 1.53 KiB | 0 bytes/s, done.
	Total 6 (delta 3), reused 0 (delta 0)
	remote: Resolving deltas: 100% (3/3), completed with 3 local objects.
	To https://github.com/nastark519/nastark519.github.io.git
	   29b65d5..ce10910  hw3 -> hw3

	nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (hw3)
	$ git add .

	nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (hw3)
	$ git commit -m "Working now on what should be the last part of the Calculator.                                                                                             Working in the method DoCalculation."
	[hw3 cc8ea6e] Working now on what should be the last part of the Calculator. Wor                                                                                            king in the method DoCalculation.
	 1 file changed, 31 insertions(+), 4 deletions(-)

	nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (hw3)
	$ git push hw1pages hw3
	Counting objects: 6, done.
	Delta compression using up to 4 threads.
	Compressing objects: 100% (5/5), done.
	Writing objects: 100% (6/6), 894 bytes | 0 bytes/s, done.
	Total 6 (delta 3), reused 0 (delta 0)
	remote: Resolving deltas: 100% (3/3), completed with 3 local objects.
	To https://github.com/nastark519/nastark519.github.io.git
	   ce10910..cc8ea6e  hw3 -> hw3

	nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (hw3)
	$ git add .

	nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (hw3)
	$ git commit -m "All done! I had to go through the debugger to find that I neede                                                                                            d to switch the .Data with .data aswell as .Next  to .next"
	[hw3 07d94bc] All done! I had to go through the debugger to find that I needed t                                                                                            o switch the .Data with .data aswell as .Next  to .next
	 1 file changed, 24 insertions(+), 11 deletions(-)

	nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (hw3)
	$ git push hw1pages hw3
	Counting objects: 6, done.
	Delta compression using up to 4 threads.
	Compressing objects: 100% (5/5), done.
	Writing objects: 100% (6/6), 787 bytes | 0 bytes/s, done.
	Total 6 (delta 3), reused 0 (delta 0)
	remote: Resolving deltas: 100% (3/3), completed with 3 local objects.
	To https://github.com/nastark519/nastark519.github.io.git
	   cc8ea6e..07d94bc  hw3 -> hw3

	nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (hw3)
	$ git merge master
	Already up-to-date.

	nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (hw3)
	$ git checkout master
	Switched to branch 'master'
	Your branch is up-to-date with 'hw1pages/master'.

	nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (master)
	$ git merge hw3
	Updating 611a400..07d94bc
	Fast-forward
	 .gitignore                                         | 261 +++++++++++++++++
	 HW3/homeWork3/homeWork3.sln                        |  25 ++
	 HW3/homeWork3/homeWork3/App.config                 |   6 +
	 HW3/homeWork3/homeWork3/Program.cs                 | 320 +++++++++++++++++++++
	 HW3/homeWork3/homeWork3/Properties/AssemblyInfo.cs |  36 +++
	 HW3/homeWork3/homeWork3/homeWork3.csproj           |  52 ++++
	 6 files changed, 700 insertions(+)
	 create mode 100644 .gitignore
	 create mode 100644 HW3/homeWork3/homeWork3.sln
	 create mode 100644 HW3/homeWork3/homeWork3/App.config
	 create mode 100644 HW3/homeWork3/homeWork3/Program.cs
	 create mode 100644 HW3/homeWork3/homeWork3/Properties/AssemblyInfo.cs
	 create mode 100644 HW3/homeWork3/homeWork3/homeWork3.csproj

	nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (master)
	$ git push hw1pages hw3
	Everything up-to-date

	nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (master)
	$ git push hw1pages master
	Total 0 (delta 0), reused 0 (delta 0)
	To https://github.com/nastark519/nastark519.github.io.git
	   611a400..07d94bc  master -> master
	```
