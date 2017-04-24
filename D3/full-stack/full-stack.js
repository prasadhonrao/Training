var margin = { top: 30, right: 0, bottom: 0, left: 0 },
    width = 1200,
    height = 600 - margin.top - margin.bottom,
    formatNumber = d3.format(",d"),
    transitioning;

var x = d3.scale.linear()
    .domain([0, width])
    .range([0, width]);

var y = d3.scale.linear()
    .domain([0, height])
    .range([0, height]);

var treemap = d3.layout.treemap()
    .children(function (d, depth) { return depth ? null : d._children; })
    .sort(function (a, b) { return a.value - b.value; })
    .ratio(height / width * 0.5 * (1 + Math.sqrt(5)))
    .round(false);

var svg = d3.select(".chart").append("svg")
    .attr("width", width + margin.left + margin.right)
    .attr("height", height + margin.bottom + margin.top)
    .style("margin-left", -margin.left + "px")
    .style("margin.right", -margin.right + "px")
    .append("g")
    .attr("transform", "translate(" + margin.left + "," + margin.top + ")")
    .style("shape-rendering", "crispEdges");


var grandparent = svg.append("g")
    .attr("class", "grandparent");

var processData = {
    "name": "Layer",
    "children": [
        {
            "name": "Data Processing",
            "children": [
                {
                    "name": "Patterns",
                    "children": [
                        {
                            "name": "Async Processing",
                            "value": 2
                        },
                        {
                            "name": "Batch Processing",
                            "value": 1
                        },
                        {
                            "name": "Stream Processing",
                            "value": 1
                        },
                        {
                            "name": "Business Process Orchestration",
                            "value": 1
                        },
                        {
                            "name": "Microservices",
                            "value": 1
                        },
                        {
                            "name": "Data Access",
                            "value": 1
                        },
                        {
                            "name": "Grid Computing",
                            "value": 1
                        }
                    ]
                },
                {
                    "name": "Frameworks",
                    "children": [
                        {
                            "name": "Akka",
                            "value": 1
                        },
                        {
                            "name": "Map Reduce",
                            "value": 1
                        },
                        {
                            "name": "Storm",
                            "value": 1
                        },
                        {
                            "name": "Play",
                            "value": 1
                        },
                        {
                            "name": "Apache Pig",
                            "value": 1
                        },
                        {
                            "name": "Spark",
                            "value": 1
                        },
                        {
                            "name": "Apache Hive",
                            "value": 1
                        },
                        {
                            "name": "Spring Batch",
                            "value": 1
                        },
                        {
                            "name": "Easy Batch",
                            "value": 1
                        },
                        {
                            "name": "Trident Storm",
                            "value": 1
                        },
                        {
                            "name": "Spring Boot",
                            "value": 1
                        },
                        {
                            "name": "Azure Data Fabric",
                            "value": 1
                        },
                        {
                            "name": "JPA",
                            "value": 1
                        },
                        {
                            "name": "Hibernate",
                            "value": 1
                        },
                        {
                            "name": "iBatis",
                            "value": 1
                        },
                        {
                            "name": "Spring Data",
                            "value": 1
                        },
                        {
                            "name": "ADO.NET",
                            "value": 1
                        },
                        {
                            "name": "Entity Framework",
                            "value": 1
                        }
                    ]
                },
                {
                    "name": "Products",
                    "children": [
                        {
                            "name": "IBM BPM",
                            "value": 1
                        },
                        {
                            "name": "Pega",
                            "value": 1
                        },
                        {
                            "name": "Appain",
                            "value": 1
                        },
                        {
                            "name": "JBPM",
                            "value": 1
                        },
                        {
                            "name": "Activiti",
                            "value": 1
                        },
                        {
                            "name": "MS BizTalk",
                            "value": 1
                        },
                        {
                            "name": "WWF",
                            "value": 1
                        },
                        {
                            "name": "InRule",
                            "value": 1
                        },
                        {
                            "name": "AWS Lambda",
                            "value": 1
                        },
                        {
                            "name": "NodeJS",
                            "value": 1
                        },
                        {
                            "name": "SAP Hana",
                            "value": 1
                        },
                        {
                            "name": "Apache Spaces",
                            "value": 1
                        },
                        {
                            "name": "Giga Spaces",
                            "value": 1
                        }
                    ]
                }
            ]
        },
        {
            "name": "Analytics",
            "children": [
                {
                    "name": "Pattern",
                    "children": [
                        {
                            "name": "Reporting",
                            "value": 1
                        },
                        {
                            "name": "Data Mining",
                            "value": 1
                        }
                    ]
                },
                {
                    "name": "Frameworks",
                    "children": [
                        {
                            "name": "R Analytics",
                            "value": 1
                        }
                    ]
                },
                {
                    "name": "Products",
                    "children": [
                        {
                            "name": "Oracle ODM",
                            "value": 1
                        },
                        {
                            "name": "TIBCO Spotfire",
                            "value": 1
                        },
                        {
                            "name": "IBM Cognos",
                            "value": 1
                        },
                        {
                            "name": "HP Vertica",
                            "value": 1
                        },
                        {
                            "name": "JASPER",
                            "value": 1
                        },
                        {
                            "name": "IBM SPSS",
                            "value": 1
                        },
                        {
                            "name": "BIRT",
                            "value": 1
                        },
                        {
                            "name": "Open Text",
                            "value": 1
                        },
                        {
                            "name": "Qlik",
                            "value": 1
                        },
                        {
                            "name": "Teradata Miner",
                            "value": 1
                        },
                        {
                            "name": "Tablau",
                            "value": 1
                        },
                        {
                            "name": "SAS",
                            "value": 1
                        },
                        {
                            "name": "Crystal Reports",
                            "value": 1
                        },
                        {
                            "name": "Pentaho BA",
                            "value": 1
                        },
                        {
                            "name": "Apache Mahout",
                            "value": 1
                        },
                        {
                            "name": "Micro Strategy",
                            "value": 1
                        }
                    ]
                }
            ]
        },
        {
            "name": "Integration",
            "children": [
                {
                    "name": "Patterns",
                    "children": [
                        {
                            "name": "EAI Patterns",
                            "value": 1
                        },
                        {
                            "name": "Enterprise Service Bus",
                            "value": 1
                        },
                        {
                            "name": "Messaging",
                            "value": 1
                        }
                    ]
                },
                {
                    "name": "Frameworks",
                    "children": [
                        {
                            "name": "Spring Integration",
                            "value": 1
                        },
                        {
                            "name": "Apache Camel",
                            "value": 1
                        }
                    ]
                },
                {
                    "name": "Products",
                    "children": [
                        {
                            "name": "JBoss Fuse",
                            "value": 1
                        },
                        {
                            "name": "IBM Integration Bus",
                            "value": 1
                        },
                        {
                            "name": "Mulesoft",
                            "value": 1
                        },
                        {
                            "name": "Kafka",
                            "value": 1
                        },
                        {
                            "name": "Rabbit MQ",
                            "value": 1
                        },
                        {
                            "name": "Active MQ",
                            "value": 1
                        },
                        {
                            "name": "Websphere MQ",
                            "value": 1
                        }
                    ]
                }
            ]
        },
        {
            "name": "Data Persistence",
            "children": [
                {
                    "name": "Patterns",
                    "children": [
                        {
                            "name": "Relational FB",
                            "value": 1
                        },
                        {
                            "name": "Distributed File System",
                            "value": 1
                        },
                        {
                            "name": "NOSQL DB",
                            "value": 1
                        },
                        {
                            "name": "NewSQL DB",
                            "value": 1
                        },
                        {
                            "name": "Data Wareouse",
                            "value": 1
                        },
                        {
                            "name": "Caching",
                            "value": 1
                        }
                    ]
                },
                {
                    "name": "Frameworks",
                    "children": [
                        {
                            "name": "Memcached",
                            "value": 1
                        },
                        {
                            "name": "EH Cache",
                            "value": 1
                        },
                        {
                            "name": "JBoss Cache",
                            "value": 1
                        },
                        {
                            "name": "ASP.NET Caching",
                            "value": 1
                        }
                    ]
                },
                {
                    "name": "Products",
                    "children": [
                        {
                            "name": "Redis",
                            "value": 1
                        },
                        {
                            "name": "Hazelcast",
                            "value": 1
                        },
                        {
                            "name": "HBase",
                            "value": 1
                        },
                        {
                            "name": "Google Spanner",
                            "value": 1
                        },
                        {
                            "name": "Oracle Exa Data",
                            "value": 1
                        },
                        {
                            "name": "Cassandra",
                            "value": 1
                        },
                        {
                            "name": "MemSQL",
                            "value": 1
                        },
                        {
                            "name": "Tera Data",
                            "value": 1
                        },
                        {
                            "name": "Mondo DB",
                            "value": 1
                        },
                        {
                            "name": "Volt DB",
                            "value": 1
                        },
                        {
                            "name": "Ab Initio",
                            "value": 1
                        },
                        {
                            "name": "Neo4J",
                            "value": 1
                        },
                        {
                            "name": "Cockroach DB",
                            "value": 1
                        },
                        {
                            "name": "Amazon Redshift",
                            "value": 1
                        },
                        {
                            "name": "CouchDB",
                            "value": 1
                        },
                        {
                            "name": "Clustrix",
                            "value": 1
                        },
                        {
                            "name": "Greenplum",
                            "value": 1
                        },
                        {
                            "name": "Amazon Dynamo",
                            "value": 1
                        },
                        {
                            "name": "Nuo DB",
                            "value": 1
                        },
                        {
                            "name": "MarkLogic",
                            "value": 1
                        },
                        {
                            "name": "Azure SQL",
                            "value": 1
                        },
                        {
                            "name": "Oracle",
                            "value": 1
                        },
                        {
                            "name": "HDFS",
                            "value": 1
                        },
                        {
                            "name": "MySQL",
                            "value": 1
                        },
                        {
                            "name": "Amazon S3",
                            "value": 1
                        },
                        {
                            "name": "SQL Server",
                            "value": 1
                        },
                        {
                            "name": "DB2",
                            "value": 1
                        },
                        {
                            "name": "PostgresSQL",
                            "value": 1
                        },
                        {
                            "name": "Apache Derby",
                            "value": 1
                        },
                        {
                            "name": "Sybase",
                            "value": 1
                        }
                    ]
                },
                {
                    "name": "Softback",
                    "children": [
                        {
                            "name": "Photo 1",
                            "value": 1
                        },
                        {
                            "name": "Photo 3",
                            "value": 1
                        }
                    ]
                },
                {
                    "name": "Hardback",
                    "children": [
                        {
                            "name": "Photo 1",
                            "value": 1
                        },
                        {
                            "name": "Photo 2",
                            "value": 1
                        },
                        {
                            "name": "Photo 3",
                            "value": 1
                        },
                        {
                            "name": "Photo 4",
                            "value": 1
                        }
                    ]
                }
            ]
        },
        {
            "name": "Channel",
            "children": [
                {
                    "name": "Patterns",
                    "children": [
                        {
                            "name": "Native Mobile",
                            "value": 1
                        },
                        {
                            "name": "Hybrid Mobile",
                            "value": 1
                        },
                        {
                            "name": "Client Side MVC",
                            "value": 1
                        },
                        {
                            "name": "Client Side Frameworks",
                            "value": 1
                        },
                        {
                            "name": "Omni Channel Architecture",
                            "value": 1
                        },
                        {
                            "name": "Responsive Web Design",
                            "value": 1
                        }
                    ]
                },
                {
                    "name": "Frameworks",
                    "children": [
                        {
                            "name": "Bootstrap",
                            "value": 1
                        },
                        {
                            "name": "Foundation",
                            "value": 1
                        },
                        {
                            "name": "DOJO",
                            "value": 1
                        },
                        {
                            "name": "jQuery",
                            "value": 1
                        },
                        {
                            "name": "Anguarl 1.X",
                            "value": 1
                        },
                        {
                            "name": "Angular 2.0",
                            "value": 1
                        },
                        {
                            "name": "Polymer JS",
                            "value": 1
                        },
                        {
                            "name": "Ember JS",
                            "value": 1
                        },
                        {
                            "name": "Sencha extJS",
                            "value": 1
                        },
                        {
                            "name": "Xamarin",
                            "value": 1
                        },
                        {
                            "name": "Ionic",
                            "value": 1
                        },
                        {
                            "name": "KendoUI",
                            "value": 1
                        },
                        {
                            "name": "Cordova",
                            "value": 1
                        },
                        {
                            "name": "Phonegap",
                            "value": 1
                        },
                        {
                            "name": "Native iOS",
                            "value": 1
                        },
                        {
                            "name": "Native Android",
                            "value": 1
                        },
                        {
                            "name": "Native Windows",
                            "value": 1
                        }
                    ]
                },
                {
                    "name": "Products",
                    "children": [
                        {
                            "name": "Kony",
                            "value": 1
                        },
                        {
                            "name": "Backbase",
                            "value": 1
                        },
                        {
                            "name": "Crealogix",
                            "value": 1
                        },
                        {
                            "name": "CR2",
                            "value": 1
                        },
                        {
                            "name": "Temenoes Edge Connect",
                            "value": 1
                        }
                    ]
                }
            ]
        },
        {
            "name": "Endpoint",
            "children": [
                {
                    "name": "Patterns",
                    "children": [
                        {
                            "name": "Traditional Web Rendering",
                            "value": 1
                        },
                        {
                            "name": "Server Side MVC",
                            "value": 1
                        },
                        {
                            "name": "REST API",
                            "value": 1
                        },
                        {
                            "name": "SOAP",
                            "value": 1
                        },
                        {
                            "name": "Event Driven",
                            "value": 1
                        }
                    ]
                },
                {
                    "name": "Frameworks",
                    "children": [
                        {
                            "name": "PHP",
                            "value": 1
                        },
                        {
                            "name": "ASP.NET MVC",
                            "value": 1
                        },
                        {
                            "name": "WCF.NEt",
                            "value": 1
                        },
                        {
                            "name": "Apache Axis 2",
                            "value": 1
                        },
                        {
                            "name": "JMS",
                            "value": 1
                        },
                        {
                            "name": "JSP / Servlet",
                            "value": 1
                        },
                        {
                            "name": "Spring MVC",
                            "value": 1
                        },
                        {
                            "name": "Jersey",
                            "value": 1
                        },
                        {
                            "name": "JAX-WS",
                            "value": 1
                        },
                        {
                            "name": "AMQP",
                            "value": 1
                        },
                        {
                            "name": "ASP.NET",
                            "value": 1
                        },
                        {
                            "name": "Struts",
                            "value": 1
                        },
                        {
                            "name": "Spring MVC",
                            "value": 1
                        },
                        {
                            "name": "MSMQ",
                            "value": 1
                        },
                        {
                            "name": "DJANGO REST",
                            "value": 1
                        },
                        {
                            "name": "JAX-Rs",
                            "value": 1
                        }
                    ]
                },
                {
                    "name": "Products",
                    "children": []
                }
            ]
        },
        {
            "name": "Data Ingestion",
            "children": [
                {
                    "name": "Patterns",
                    "children": [
                        {
                            "name": "File Ingestion",
                            "value": 1
                        },
                        {
                            "name": "Streaming Data",
                            "value": 1
                        },
                        {
                            "name": "Traditional ETL",
                            "value": 1
                        }
                    ]
                },
                {
                    "name": "Framworks",
                    "children": [
                        {
                            "name": "Log Stash",
                            "value": 1
                        }
                    ]
                },
                {
                    "name": "Products",
                    "children": [
                        {
                            "name": "Splunk",
                            "value": 1
                        },
                        {
                            "name": "Informatica",
                            "value": 1
                        },
                        {
                            "name": "IBM Data Stage",
                            "value": 1
                        },
                        {
                            "name": "Oracle Data Integrator",
                            "value": 1
                        },
                        {
                            "name": "Pentago Data Integration",
                            "value": 1
                        },
                        {
                            "name": "SAP Data Services",
                            "value": 1
                        },
                        {
                            "name": "SSIS",
                            "value": 1
                        },
                        {
                            "name": "Talend",
                            "value": 1
                        }
                    ]
                }
            ]
        },
        {
            "name": "Core Business Logic",
            "children": [
                {
                    "name": "Patterns",
                    "children": [
                        {
                            "name": "Logic Containers",
                            "value": 1
                        },
                        {
                            "name": "Transaction Management",
                            "value": 1
                        }
                    ]
                },
                {
                    "name": "Frameworks",
                    "children": [
                        {
                            "name": "JTA",
                            "value": 1
                        },
                        {
                            "name": "Spring Transaction Management",
                            "value": 1
                        },
                        {
                            "name": "Botronix",
                            "value": 1
                        },
                        {
                            "name": "Atomikos",
                            "value": 1
                        },
                        {
                            "name": "Spring IOT",
                            "value": 1
                        },
                        {
                            "name": "Google Guice",
                            "value": 1
                        },
                        {
                            "name": "JBOSss Microcontainer",
                            "value": 1
                        },
                        {
                            "name": "Windows Service Container",
                            "value": 1
                        },
                        {
                            "name": "EJB",
                            "value": 1
                        }
                    ]
                },
                {
                    "name": "Products",
                    "children": []
                }
            ]
        }
    ]
}

grandparent.append("rect")
    .attr("y", -margin.top)
    .attr("width", width)
    .attr("height", margin.top);

grandparent.append("text")
    .attr("x", 6)
    .attr("y", 6 - margin.top)
    .attr("dy", ".75em");

root = processData;

initialize(root);
accumulate(root);
layout(root);
display(root);

function initialize(root) {
    root.x = root.y = 0;
    root.dx = width;
    root.dy = height;
    root.depth = 0;
}

// Aggregate the values for internal nodes. This is normally done by the
// treemap layout, but not here because of our custom implementation.
// We also take a snapshot of the original children (_children) to avoid
// the children being overwritten when when layout is computed.
function accumulate(d) {
    return (d._children = d.children)
        ? d.value = d.children.reduce(function (p, v) { return p + accumulate(v); }, 0)
        : d.value;
}

// Compute the treemap layout recursively such that each group of siblings
// uses the same size (1×1) rather than the dimensions of the parent cell.
// This optimizes the layout for the current zoom state. Note that a wrapper
// object is created for the parent node for each group of siblings so that
// the parent’s dimensions are not discarded as we recurse. Since each group
// of sibling was laid out in 1×1, we must rescale to fit using absolute
// coordinates. This lets us use a viewport to zoom.
function layout(d) {
    if (d._children) {
        treemap.nodes({ _children: d._children });
        d._children.forEach(function (c) {
            c.x = d.x + c.x * d.dx;
            c.y = d.y + c.y * d.dy;
            c.dx *= d.dx;
            c.dy *= d.dy;
            c.parent = d;
            layout(c);
        });
    }
}

function display(d) {
    grandparent
        .datum(d.parent)
        .on("click", transition)
        .select("text")
        .text(name(d));

    var g1 = svg.insert("g", ".grandparent")
        .datum(d)
        .attr("class", "depth");

    var g = g1.selectAll("g")
        .data(d._children)
        .enter().append("g");

    g.filter(function (d) { return d._children; })
        .classed("children", true)
        .on("click", transition);

    g.selectAll(".child")
        .data(function (d) { return d._children || [d]; })
        .enter().append("rect")
        .attr("class", "child")
        .call(rect);

    g.append("rect")
        .attr("class", "parent")
        .call(rect)
        .append("title")
        .text(function (d) { return formatNumber(d.value); });

    g.append("text")
        .attr("dy", ".75em")
        .text(function (d) { return d.name; })
        .call(text);

    function transition(d) {
        if (transitioning || !d) return;
        transitioning = true;

        var g2 = display(d),
            t1 = g1.transition().duration(750),
            t2 = g2.transition().duration(750);

        // Update the domain only after entering new elements.
        x.domain([d.x, d.x + d.dx]);
        y.domain([d.y, d.y + d.dy]);

        // Enable anti-aliasing during the transition.
        svg.style("shape-rendering", null);

        // Draw child nodes on top of parent nodes.
        svg.selectAll(".depth").sort(function (a, b) { return a.depth - b.depth; });

        // Fade-in entering text.
        g2.selectAll("text").style("fill-opacity", 0);

        // Transition to the new view.
        t1.selectAll("text").call(text).style("fill-opacity", 0);
        t2.selectAll("text").call(text).style("fill-opacity", 1);
        t1.selectAll("rect").call(rect);
        t2.selectAll("rect").call(rect);

        // Remove the old node when the transition is finished.
        t1.remove().each("end", function () {
            svg.style("shape-rendering", "crispEdges");
            transitioning = false;
        });
    }

    return g;
}

function text(text) {
    text.attr("x", function (d) { return x(d.x) + 6; })
        .attr("y", function (d) { return y(d.y) + 6; });
}

function rect(rect) {
    rect.attr("x", function (d) { return x(d.x); })
        .attr("y", function (d) { return y(d.y); })
        .attr("width", function (d) { return x(d.x + d.dx) - x(d.x); })
        .attr("height", function (d) { return y(d.y + d.dy) - y(d.y); });
}

function name(d) {
    return d.parent
        ? name(d.parent) + "/" + d.name
        : d.name;
}