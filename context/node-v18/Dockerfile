FROM node:18.12-bullseye

# @vue/cli -> use vite
# RUN yarn global add @vue/cli

# @angular/cli
RUN yarn global add @angular/cli

# nx cli
RUN yarn global add nx

WORKDIR /usr/workspace

# vscode extensions
COPY workspace.code-workspace /root
COPY .bashrc /root

CMD [ "/bin/bash" ]