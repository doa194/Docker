FROM fluent/fluentd:v1.16-1.4 

USER root # Switch to root user to install plugins

RUN gem install fluent-plugin-elasticsearch -v 5.6. # Install the elasticsearch plugin

USER fluent # Switch back to the fluent user