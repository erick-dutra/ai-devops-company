import { useState, useEffect } from 'react'
import { Card, CardContent, CardDescription, CardHeader, CardTitle } from '@/components/ui/card'
import { Button } from '@/components/ui/button'
import { Badge } from '@/components/ui/badge'
import { Input } from '@/components/ui/input'
import { Label } from '@/components/ui/label'
import { Textarea } from '@/components/ui/textarea'
import { Select, SelectContent, SelectItem, SelectTrigger, SelectValue } from '@/components/ui/select'
import { Dialog, DialogContent, DialogDescription, DialogHeader, DialogTitle, DialogTrigger } from '@/components/ui/dialog'
import { Table, TableBody, TableCell, TableHead, TableHeader, TableRow } from '@/components/ui/table'
import { Tabs, TabsContent, TabsList, TabsTrigger } from '@/components/ui/tabs'
import { Progress } from '@/components/ui/progress'
import {
  Code,
  Play,
  Download,
  Eye,
  GitBranch,
  FileText,
  Zap,
  CheckCircle,
  Clock,
  AlertTriangle,
  Plus,
  Search,
  Filter
} from 'lucide-react'

export function Development() {
  const [tasks, setTasks] = useState([
    {
      id: 'dev-001',
      title: 'API Authentication System',
      description: 'Implementar sistema de autenticação JWT para a API',
      status: 'Completed',
      priority: 'High',
      language: 'C#',
      assignedAgent: 'Development.001',
      createdAt: '2024-01-18T09:00:00Z',
      completedAt: '2024-01-20T15:30:00Z',
      codeQuality: 94,
      testCoverage: 87,
      linesOfCode: 1250,
      complexity: 'Medium',
      generatedCode: true,
      hasTests: true,
      codeVersions: 3
    },
    {
      id: 'dev-002',
      title: 'Payment Gateway Integration',
      description: 'Integrar gateway de pagamento Stripe',
      status: 'In Progress',
      priority: 'High',
      language: 'JavaScript',
      assignedAgent: 'Development.001',
      createdAt: '2024-01-19T10:15:00Z',
      completedAt: null,
      codeQuality: 89,
      testCoverage: 72,
      linesOfCode: 890,
      complexity: 'High',
      generatedCode: true,
      hasTests: true,
      codeVersions: 2
    },
    {
      id: 'dev-003',
      title: 'User Dashboard Components',
      description: 'Criar componentes React para dashboard do usuário',
      status: 'Planning',
      priority: 'Medium',
      language: 'TypeScript',
      assignedAgent: 'Development.001',
      createdAt: '2024-01-20T14:00:00Z',
      completedAt: null,
      codeQuality: null,
      testCoverage: null,
      linesOfCode: null,
      complexity: 'Low',
      generatedCode: false,
      hasTests: false,
      codeVersions: 0
    }
  ])

  const [codeVersions, setCodeVersions] = useState([
    {
      id: 'ver-001',
      taskId: 'dev-001',
      version: 'v1.0',
      description: 'Versão inicial com autenticação básica',
      createdAt: '2024-01-18T12:00:00Z',
      createdBy: 'Development.001',
      size: '2.3 MB',
      testResults: 'Passed',
      qualityScore: 92
    },
    {
      id: 'ver-002',
      taskId: 'dev-001',
      version: 'v1.1',
      description: 'Adicionado refresh token e validações',
      createdAt: '2024-01-19T16:30:00Z',
      createdBy: 'Development.001',
      size: '2.8 MB',
      testResults: 'Passed',
      qualityScore: 94
    },
    {
      id: 'ver-003',
      taskId: 'dev-002',
      version: 'v1.0',
      description: 'Integração inicial com Stripe',
      createdAt: '2024-01-20T11:15:00Z',
      createdBy: 'Development.001',
      size: '1.9 MB',
      testResults: 'Partial',
      qualityScore: 89
    }
  ])

  const [selectedTask, setSelectedTask] = useState(null)
  const [searchTerm, setSearchTerm] = useState('')
  const [statusFilter, setStatusFilter] = useState('all')
  const [newTask, setNewTask] = useState({
    title: '',
    description: '',
    priority: 'Medium',
    language: 'C#'
  })

  const filteredTasks = tasks.filter(task => {
    const matchesSearch = task.title.toLowerCase().includes(searchTerm.toLowerCase()) ||
                         task.description.toLowerCase().includes(searchTerm.toLowerCase())
    const matchesStatus = statusFilter === 'all' || task.status === statusFilter
    return matchesSearch && matchesStatus
  })

  const getStatusColor = (status) => {
    switch (status) {
      case 'Completed': return 'bg-green-500'
      case 'In Progress': return 'bg-blue-500'
      case 'Planning': return 'bg-yellow-500'
      case 'Failed': return 'bg-red-500'
      default: return 'bg-gray-500'
    }
  }

  const getPriorityColor = (priority) => {
    switch (priority) {
      case 'High': return 'destructive'
      case 'Medium': return 'default'
      case 'Low': return 'secondary'
      default: return 'default'
    }
  }

  const getComplexityColor = (complexity) => {
    switch (complexity) {
      case 'High': return 'text-red-600'
      case 'Medium': return 'text-yellow-600'
      case 'Low': return 'text-green-600'
      default: return 'text-gray-600'
    }
  }

  const handleCreateTask = () => {
    const task = {
      id: `dev-${String(tasks.length + 1).padStart(3, '0')}`,
      ...newTask,
      status: 'Planning',
      assignedAgent: 'Development.001',
      createdAt: new Date().toISOString(),
      completedAt: null,
      codeQuality: null,
      testCoverage: null,
      linesOfCode: null,
      complexity: 'Medium',
      generatedCode: false,
      hasTests: false,
      codeVersions: 0
    }

    setTasks([...tasks, task])
    setNewTask({
      title: '',
      description: '',
      priority: 'Medium',
      language: 'C#'
    })
  }

  const taskStats = {
    total: tasks.length,
    completed: tasks.filter(t => t.status === 'Completed').length,
    inProgress: tasks.filter(t => t.status === 'In Progress').length,
    planning: tasks.filter(t => t.status === 'Planning').length,
    avgQuality: tasks.filter(t => t.codeQuality).reduce((sum, t) => sum + t.codeQuality, 0) / tasks.filter(t => t.codeQuality).length || 0,
    avgCoverage: tasks.filter(t => t.testCoverage).reduce((sum, t) => sum + t.testCoverage, 0) / tasks.filter(t => t.testCoverage).length || 0,
    totalLines: tasks.reduce((sum, t) => sum + (t.linesOfCode || 0), 0)
  }

  return (
    <div className="space-y-6">
      {/* Header */}
      <div className="flex justify-between items-center">
        <div>
          <h2 className="text-3xl font-bold tracking-tight">Desenvolvimento</h2>
          <p className="text-muted-foreground">
            Gerencie tarefas de desenvolvimento e monitore a qualidade do código
          </p>
        </div>
        
        <Dialog>
          <DialogTrigger asChild>
            <Button>
              <Plus className="mr-2 h-4 w-4" />
              Nova Tarefa
            </Button>
          </DialogTrigger>
          <DialogContent className="sm:max-w-[500px]">
            <DialogHeader>
              <DialogTitle>Criar Nova Tarefa de Desenvolvimento</DialogTitle>
              <DialogDescription>
                Defina os requisitos para o agente de desenvolvimento
              </DialogDescription>
            </DialogHeader>
            <div className="grid gap-4 py-4">
              <div className="space-y-2">
                <Label htmlFor="title">Título da Tarefa</Label>
                <Input
                  id="title"
                  value={newTask.title}
                  onChange={(e) => setNewTask(prev => ({ ...prev, title: e.target.value }))}
                  placeholder="Ex: Implementar sistema de cache"
                />
              </div>
              
              <div className="space-y-2">
                <Label htmlFor="description">Descrição</Label>
                <Textarea
                  id="description"
                  value={newTask.description}
                  onChange={(e) => setNewTask(prev => ({ ...prev, description: e.target.value }))}
                  placeholder="Descreva os requisitos detalhados..."
                />
              </div>

              <div className="grid grid-cols-2 gap-4">
                <div className="space-y-2">
                  <Label htmlFor="priority">Prioridade</Label>
                  <Select value={newTask.priority} onValueChange={(value) => setNewTask(prev => ({ ...prev, priority: value }))}>
                    <SelectTrigger>
                      <SelectValue />
                    </SelectTrigger>
                    <SelectContent>
                      <SelectItem value="Low">Baixa</SelectItem>
                      <SelectItem value="Medium">Média</SelectItem>
                      <SelectItem value="High">Alta</SelectItem>
                    </SelectContent>
                  </Select>
                </div>
                <div className="space-y-2">
                  <Label htmlFor="language">Linguagem</Label>
                  <Select value={newTask.language} onValueChange={(value) => setNewTask(prev => ({ ...prev, language: value }))}>
                    <SelectTrigger>
                      <SelectValue />
                    </SelectTrigger>
                    <SelectContent>
                      <SelectItem value="C#">C#</SelectItem>
                      <SelectItem value="JavaScript">JavaScript</SelectItem>
                      <SelectItem value="TypeScript">TypeScript</SelectItem>
                      <SelectItem value="Python">Python</SelectItem>
                      <SelectItem value="Java">Java</SelectItem>
                    </SelectContent>
                  </Select>
                </div>
              </div>
            </div>
            
            <div className="flex justify-end space-x-2">
              <Button variant="outline">Cancelar</Button>
              <Button onClick={handleCreateTask}>Criar Tarefa</Button>
            </div>
          </DialogContent>
        </Dialog>
      </div>

      {/* Stats Cards */}
      <div className="grid gap-4 md:grid-cols-2 lg:grid-cols-4">
        <Card>
          <CardHeader className="flex flex-row items-center justify-between space-y-0 pb-2">
            <CardTitle className="text-sm font-medium">Total de Tarefas</CardTitle>
            <Code className="h-4 w-4 text-muted-foreground" />
          </CardHeader>
          <CardContent>
            <div className="text-2xl font-bold">{taskStats.total}</div>
            <p className="text-xs text-muted-foreground">
              {taskStats.inProgress} em andamento
            </p>
          </CardContent>
        </Card>

        <Card>
          <CardHeader className="flex flex-row items-center justify-between space-y-0 pb-2">
            <CardTitle className="text-sm font-medium">Qualidade Média</CardTitle>
            <CheckCircle className="h-4 w-4 text-muted-foreground" />
          </CardHeader>
          <CardContent>
            <div className="text-2xl font-bold">{taskStats.avgQuality.toFixed(1)}%</div>
            <Progress value={taskStats.avgQuality} className="mt-2" />
          </CardContent>
        </Card>

        <Card>
          <CardHeader className="flex flex-row items-center justify-between space-y-0 pb-2">
            <CardTitle className="text-sm font-medium">Cobertura de Testes</CardTitle>
            <Zap className="h-4 w-4 text-muted-foreground" />
          </CardHeader>
          <CardContent>
            <div className="text-2xl font-bold">{taskStats.avgCoverage.toFixed(1)}%</div>
            <Progress value={taskStats.avgCoverage} className="mt-2" />
          </CardContent>
        </Card>

        <Card>
          <CardHeader className="flex flex-row items-center justify-between space-y-0 pb-2">
            <CardTitle className="text-sm font-medium">Linhas de Código</CardTitle>
            <FileText className="h-4 w-4 text-muted-foreground" />
          </CardHeader>
          <CardContent>
            <div className="text-2xl font-bold">{taskStats.totalLines.toLocaleString()}</div>
            <p className="text-xs text-muted-foreground">
              Geradas pelos agentes
            </p>
          </CardContent>
        </Card>
      </div>

      {/* Filters and Search */}
      <div className="flex flex-col sm:flex-row gap-4">
        <div className="relative flex-1">
          <Search className="absolute left-3 top-1/2 transform -translate-y-1/2 text-muted-foreground h-4 w-4" />
          <Input
            placeholder="Buscar tarefas..."
            value={searchTerm}
            onChange={(e) => setSearchTerm(e.target.value)}
            className="pl-10"
          />
        </div>
        
        <Select value={statusFilter} onValueChange={setStatusFilter}>
          <SelectTrigger className="w-[180px]">
            <Filter className="mr-2 h-4 w-4" />
            <SelectValue placeholder="Filtrar por status" />
          </SelectTrigger>
          <SelectContent>
            <SelectItem value="all">Todos os Status</SelectItem>
            <SelectItem value="Planning">Planejamento</SelectItem>
            <SelectItem value="In Progress">Em Andamento</SelectItem>
            <SelectItem value="Completed">Concluído</SelectItem>
            <SelectItem value="Failed">Falhou</SelectItem>
          </SelectContent>
        </Select>
      </div>

      {/* Main Content */}
      <Tabs defaultValue="tasks" className="space-y-4">
        <TabsList>
          <TabsTrigger value="tasks">Tarefas de Desenvolvimento</TabsTrigger>
          <TabsTrigger value="versions">Versões de Código</TabsTrigger>
          <TabsTrigger value="analytics">Análise de Código</TabsTrigger>
        </TabsList>

        <TabsContent value="tasks" className="space-y-4">
          <Card>
            <CardHeader>
              <CardTitle>Tarefas de Desenvolvimento</CardTitle>
              <CardDescription>
                Acompanhe o progresso das tarefas executadas pelos agentes de IA
              </CardDescription>
            </CardHeader>
            <CardContent>
              <Table>
                <TableHeader>
                  <TableRow>
                    <TableHead>Tarefa</TableHead>
                    <TableHead>Status</TableHead>
                    <TableHead>Prioridade</TableHead>
                    <TableHead>Linguagem</TableHead>
                    <TableHead>Qualidade</TableHead>
                    <TableHead>Cobertura</TableHead>
                    <TableHead>Complexidade</TableHead>
                    <TableHead>Ações</TableHead>
                  </TableRow>
                </TableHeader>
                <TableBody>
                  {filteredTasks.map((task) => (
                    <TableRow key={task.id}>
                      <TableCell>
                        <div>
                          <div className="font-medium">{task.title}</div>
                          <div className="text-sm text-muted-foreground">
                            {task.description.substring(0, 50)}...
                          </div>
                        </div>
                      </TableCell>
                      <TableCell>
                        <Badge variant="outline" className={`${getStatusColor(task.status)} text-white`}>
                          {task.status}
                        </Badge>
                      </TableCell>
                      <TableCell>
                        <Badge variant={getPriorityColor(task.priority)}>
                          {task.priority}
                        </Badge>
                      </TableCell>
                      <TableCell>
                        <Badge variant="secondary">{task.language}</Badge>
                      </TableCell>
                      <TableCell>
                        {task.codeQuality ? (
                          <div className="flex items-center space-x-2">
                            <span className="text-sm">{task.codeQuality}%</span>
                            <Progress value={task.codeQuality} className="w-[60px]" />
                          </div>
                        ) : (
                          <span className="text-muted-foreground">-</span>
                        )}
                      </TableCell>
                      <TableCell>
                        {task.testCoverage ? (
                          <div className="flex items-center space-x-2">
                            <span className="text-sm">{task.testCoverage}%</span>
                            <Progress value={task.testCoverage} className="w-[60px]" />
                          </div>
                        ) : (
                          <span className="text-muted-foreground">-</span>
                        )}
                      </TableCell>
                      <TableCell>
                        <span className={`text-sm font-medium ${getComplexityColor(task.complexity)}`}>
                          {task.complexity}
                        </span>
                      </TableCell>
                      <TableCell>
                        <div className="flex space-x-2">
                          <Button variant="ghost" size="sm">
                            <Eye className="h-4 w-4" />
                          </Button>
                          {task.generatedCode && (
                            <Button variant="ghost" size="sm">
                              <Download className="h-4 w-4" />
                            </Button>
                          )}
                        </div>
                      </TableCell>
                    </TableRow>
                  ))}
                </TableBody>
              </Table>
            </CardContent>
          </Card>
        </TabsContent>

        <TabsContent value="versions" className="space-y-4">
          <Card>
            <CardHeader>
              <CardTitle>Versões de Código</CardTitle>
              <CardDescription>
                Histórico de versões geradas pelos agentes com evidências de teste
              </CardDescription>
            </CardHeader>
            <CardContent>
              <Table>
                <TableHeader>
                  <TableRow>
                    <TableHead>Versão</TableHead>
                    <TableHead>Tarefa</TableHead>
                    <TableHead>Descrição</TableHead>
                    <TableHead>Criado em</TableHead>
                    <TableHead>Tamanho</TableHead>
                    <TableHead>Testes</TableHead>
                    <TableHead>Qualidade</TableHead>
                    <TableHead>Ações</TableHead>
                  </TableRow>
                </TableHeader>
                <TableBody>
                  {codeVersions.map((version) => (
                    <TableRow key={version.id}>
                      <TableCell>
                        <Badge variant="outline">{version.version}</Badge>
                      </TableCell>
                      <TableCell>
                        {tasks.find(t => t.id === version.taskId)?.title || 'N/A'}
                      </TableCell>
                      <TableCell>{version.description}</TableCell>
                      <TableCell>
                        {new Date(version.createdAt).toLocaleDateString()}
                      </TableCell>
                      <TableCell>{version.size}</TableCell>
                      <TableCell>
                        <Badge variant={version.testResults === 'Passed' ? 'default' : 'destructive'}>
                          {version.testResults}
                        </Badge>
                      </TableCell>
                      <TableCell>
                        <div className="flex items-center space-x-2">
                          <span className="text-sm">{version.qualityScore}%</span>
                          <Progress value={version.qualityScore} className="w-[60px]" />
                        </div>
                      </TableCell>
                      <TableCell>
                        <div className="flex space-x-2">
                          <Button variant="ghost" size="sm">
                            <Download className="h-4 w-4" />
                          </Button>
                          <Button variant="ghost" size="sm">
                            <Eye className="h-4 w-4" />
                          </Button>
                        </div>
                      </TableCell>
                    </TableRow>
                  ))}
                </TableBody>
              </Table>
            </CardContent>
          </Card>
        </TabsContent>

        <TabsContent value="analytics" className="space-y-4">
          <div className="grid gap-4 md:grid-cols-2">
            <Card>
              <CardHeader>
                <CardTitle>Métricas de Qualidade</CardTitle>
                <CardDescription>
                  Análise da qualidade do código gerado
                </CardDescription>
              </CardHeader>
              <CardContent className="space-y-4">
                <div className="space-y-2">
                  <div className="flex justify-between">
                    <span className="text-sm">Qualidade Média</span>
                    <span className="text-sm font-medium">{taskStats.avgQuality.toFixed(1)}%</span>
                  </div>
                  <Progress value={taskStats.avgQuality} />
                </div>
                
                <div className="space-y-2">
                  <div className="flex justify-between">
                    <span className="text-sm">Cobertura de Testes</span>
                    <span className="text-sm font-medium">{taskStats.avgCoverage.toFixed(1)}%</span>
                  </div>
                  <Progress value={taskStats.avgCoverage} />
                </div>
                
                <div className="space-y-2">
                  <div className="flex justify-between">
                    <span className="text-sm">Taxa de Sucesso</span>
                    <span className="text-sm font-medium">94.2%</span>
                  </div>
                  <Progress value={94.2} />
                </div>
              </CardContent>
            </Card>

            <Card>
              <CardHeader>
                <CardTitle>Distribuição por Linguagem</CardTitle>
                <CardDescription>
                  Tarefas por linguagem de programação
                </CardDescription>
              </CardHeader>
              <CardContent className="space-y-4">
                <div className="space-y-3">
                  <div className="flex justify-between items-center">
                    <span className="text-sm">C#</span>
                    <div className="flex items-center space-x-2">
                      <Progress value={40} className="w-[100px]" />
                      <span className="text-sm text-muted-foreground">40%</span>
                    </div>
                  </div>
                  
                  <div className="flex justify-between items-center">
                    <span className="text-sm">JavaScript</span>
                    <div className="flex items-center space-x-2">
                      <Progress value={30} className="w-[100px]" />
                      <span className="text-sm text-muted-foreground">30%</span>
                    </div>
                  </div>
                  
                  <div className="flex justify-between items-center">
                    <span className="text-sm">TypeScript</span>
                    <div className="flex items-center space-x-2">
                      <Progress value={20} className="w-[100px]" />
                      <span className="text-sm text-muted-foreground">20%</span>
                    </div>
                  </div>
                  
                  <div className="flex justify-between items-center">
                    <span className="text-sm">Python</span>
                    <div className="flex items-center space-x-2">
                      <Progress value={10} className="w-[100px]" />
                      <span className="text-sm text-muted-foreground">10%</span>
                    </div>
                  </div>
                </div>
              </CardContent>
            </Card>
          </div>
        </TabsContent>
      </Tabs>
    </div>
  )
}

