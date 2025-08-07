import { Link, useLocation } from 'react-router-dom'
import { cn } from '@/lib/utils'
import { Button } from '@/components/ui/button'
import { useAuth } from '@/contexts/AuthContext'
import {
  LayoutDashboard,
  FolderKanban,
  Code,
  TestTube,
  Server,
  GitBranch,
  Activity,
  Shield,
  DollarSign,
  Users,
  Settings,
  ChevronLeft,
  ChevronRight,
  Bot
} from 'lucide-react'

const navigation = [
  { name: 'Dashboard', href: '/dashboard', icon: LayoutDashboard, permission: 'dashboard' },
  { name: 'Gestão de Projetos', href: '/project-management', icon: FolderKanban, permission: 'project-management' },
  { name: 'Desenvolvimento', href: '/development', icon: Code, permission: 'development' },
  { name: 'Qualidade', href: '/quality-assurance', icon: TestTube, permission: 'quality-assurance' },
  { name: 'Operações', href: '/operations', icon: Server, permission: 'operations' },
  { name: 'DevOps', href: '/devops', icon: GitBranch, permission: 'devops' },
  { name: 'Monitoramento', href: '/monitoring', icon: Activity, permission: 'monitoring' },
  { name: 'Segurança', href: '/security', icon: Shield, permission: 'security' },
  { name: 'Financeiro', href: '/finance', icon: DollarSign, permission: 'finance' },
  { name: 'Recursos Humanos', href: '/human-resources', icon: Users, permission: 'human-resources' },
  { name: 'Configurações', href: '/settings', icon: Settings, permission: 'settings' },
]

export function Sidebar({ open, onToggle }) {
  const location = useLocation()
  const { hasPermission } = useAuth()

  return (
    <div className={cn(
      "bg-sidebar border-r border-sidebar-border transition-all duration-300 ease-in-out",
      open ? "w-64" : "w-16"
    )}>
      <div className="flex h-full flex-col">
        {/* Header */}
        <div className="flex h-16 items-center justify-between px-4 border-b border-sidebar-border">
          <div className={cn(
            "flex items-center space-x-2 transition-opacity duration-200",
            open ? "opacity-100" : "opacity-0"
          )}>
            <Bot className="h-8 w-8 text-sidebar-primary" />
            <span className="font-bold text-sidebar-foreground">AI DevOps</span>
          </div>
          
          <Button
            variant="ghost"
            size="sm"
            onClick={onToggle}
            className="h-8 w-8 p-0 text-sidebar-foreground hover:bg-sidebar-accent"
          >
            {open ? (
              <ChevronLeft className="h-4 w-4" />
            ) : (
              <ChevronRight className="h-4 w-4" />
            )}
          </Button>
        </div>

        {/* Navigation */}
        <nav className="flex-1 space-y-1 p-2">
          {navigation.map((item) => {
            if (!hasPermission(item.permission)) return null
            
            const isActive = location.pathname === item.href
            const Icon = item.icon

            return (
              <Link
                key={item.name}
                to={item.href}
                className={cn(
                  "flex items-center px-3 py-2 text-sm font-medium rounded-md transition-colors",
                  isActive
                    ? "bg-sidebar-accent text-sidebar-accent-foreground"
                    : "text-sidebar-foreground hover:bg-sidebar-accent hover:text-sidebar-accent-foreground",
                  !open && "justify-center"
                )}
              >
                <Icon className={cn("h-5 w-5", open && "mr-3")} />
                {open && (
                  <span className="truncate">{item.name}</span>
                )}
              </Link>
            )
          })}
        </nav>

        {/* Footer */}
        <div className="border-t border-sidebar-border p-4">
          <div className={cn(
            "text-xs text-sidebar-foreground/60 text-center",
            !open && "hidden"
          )}>
            <p>AI DevOps Company</p>
            <p>v1.0.0</p>
          </div>
        </div>
      </div>
    </div>
  )
}

