<h1>Работа с GitBash</h1>
<p>
<ol>
  <li>Создан токен через настройки профиля > Developer settings > Personal access tokens > Generate new token. выбрать repo.</li>
  <li>Был загружен проект на github с помощью ряда команд:
    <ul>
       <li>git init</li>
       <li>git add .</li>
       <li>git commin -m "comment"</li>
       <li>git remote add origin https://github.com/vlayerrt/название_репозитория.git</li>
       <li>git push "https://username:token@github.com/vlayerrt/repname.git"</li>
    </ul>
  </li>
  <li>Был копирован проект с git на локальный компьютер с помощью git clone https://github.com/vlayerrt/название_репозитория.git
</p>
<b>Команды для работы с GitBash:</b>
<ul>
  <li>git remote add origin https://github.com/vlayerrt/gitbush.git</li>
  <li>git branch -M main</li>
  <li>git push -u origin main</li>
  <li></li>
  <li>git init </li>
  <li>git add .</li>
  <li>git status</li>
  <li>git commin -m "comment"</li>
  <li>git push "https://vlayerrt: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@github.com/vlayerrt/gitbush.git"</li>
</ul>
<p>
  <h1>Примечания</h1>
  <ul>
  <li>При первой попытке загрузить проект на репозиторий была выдана ошибка: <br><br>
  
remote: warning: File .vs/opencvprojer/v16/ipch/AutoPCH/d78d84689857d72f/SOURCE.ipch is 79.88 MB; this is larger than GitHub's recommended maximum file size of 50.00 MB <br>
remote: warning: File .vs/opencvprojer/v16/ipch/AutoPCH/e32cbddd3b8429c0/SOURCE1.ipch is 79.88 MB; this is larger than GitHub's recommended maximum file size of 50.00 MB<br>
remote: error: Trace: 77bf7071ff53aa3909989032d44e9bffb3e77901ef04e612342ca0ec57d5a3f6<br>
remote: error: See http://git.io/iEPt8g for more information.<br>
remote: error: File x64/Debug/opencv_world453d.dll is 117.23 MB; this exceeds GitHub's file size limit of 100.00 MB<br>
remote: error: GH001: Large files detected. You may want to try Git Large File Storage - https://git-lfs.github.com.<br>
To https://github.com/vlayerrt/gitbush.git<br>
 ! [remote rejected] main -> main (pre-receive hook declined)<br>
error: failed to push some refs to 'https://github.com/vlayerrt/gitbush.git'<br>
</li>
<li>Для загрузки другого проекта потребовалось создать новый токен.</li>
  </ul>
</p>
