USE localdb;
CREATE TABLE fluentd_logs(
    id bigint primary key auto_increment,
    container_id nvarchar(500),
    container_name nvarchar(500),
    log nvarchar(1000)
);